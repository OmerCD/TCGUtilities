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
    public sealed partial class FactionEditWindow : Form
    {
        public Faction Faction { get; }

        public FactionEditWindow(Faction faction = null)
        {
            InitializeComponent();

            if (faction == null)
            {
                Text = "Add Faction";
                factionColorPicker.Color = Color.Red;
                Faction = new Faction();
                bApply.Text = "Add";
            }
            else
            {
                Text = "Editing " + faction.Name;
                factionColorPicker.Color = Color.FromName(faction.Color);
                Faction = DatabaseControl.CrudFaction.GetOne(faction._id);
                bApply.Text = "Edit";
            }
        }

        private void ColorChoose_Click(object sender, EventArgs e)
        {
            factionColorPicker.ShowDialog();
        }

        private void FactionEditWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SaveFaction();
                    DialogResult = DialogResult.OK;
                    break;
                case Keys.Escape:
                    DialogResult = DialogResult.Cancel;
                    break;
            }
        }

        private void SaveFaction()
        {
            var userText = tBFactionName.Text.Trim();
            if (userText.Length > 2)
            {
                Faction.Name = userText;
                Faction.Color = factionColorPicker.Color.Name;
            }
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            SaveFaction();
            DialogResult = DialogResult.OK;
        }
    }
}
