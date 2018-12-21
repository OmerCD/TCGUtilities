using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactionEditor
{
    public partial class FormFactionEditor : Form
    {
        public FormFactionEditor()
        {
            InitializeComponent();
            DatabaseControl.StartDatabaseConnection();

            LoadFactions();
        }

        private void LoadFactions()
        {
            lBFactions.Items.Clear();
            var factions = DatabaseControl.CrudFaction.GetAll();
            lBFactions.Items.AddRange(factions.ToArray());
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (var fEW = new FactionEditWindow())
            {
                if (fEW.ShowDialog() == DialogResult.OK)
                {
                    if (DatabaseControl.CrudFaction.Insert(fEW.Faction))
                    {
                        lBFactions.Items.Add(fEW.Faction);
                    }
                    
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (lBFactions.SelectedIndex != -1)
            {
                var faction = (Faction)lBFactions.SelectedItem;
                using (var fEW = new FactionEditWindow(faction))
                {
                    if (fEW.ShowDialog() == DialogResult.OK)
                    {
                        Faction faction1 = fEW.Faction;
                        if (DatabaseControl.CrudFaction.Upsert(faction1))
                        {
                            lBFactions.Items[lBFactions.SelectedIndex] = fEW.Faction;
                        }
                    }
                }
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (lBFactions.SelectedIndex != -1)
            {
                if (MessageBox.Show("Are you sure you want to delete " + lBFactions.SelectedItem + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (DatabaseControl.CrudFaction.Delete(((Faction) lBFactions.SelectedItem)._id))
                    {
                        lBFactions.Items.RemoveAt(lBFactions.SelectedIndex);
                    }
                }
            }
        }
    }
}
