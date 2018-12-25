using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardCreator.Enum;
using FactionEditor;
using MongoCRUD.Interfaces;

namespace CardCreator
{
    public partial class CardInfoPage : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
            int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Card Card
        {
            set
            {
                int GetFactionIndex(DbObject faction)
                {
                    if (faction == null) return 0;
                    for (int i = 0; i < cBFactions.Items.Count; i++)
                    {
                        if (((Faction)cBFactions.Items[i])._id == faction._id)
                        {
                            return i;
                        }
                    }
                    return -1;
                }

                var currentCard = value;
                TbName.Text = currentCard.Name;
                TbCardDescription.Text = currentCard.Description;
                NudCost.Value = currentCard.Cost;
                NudHP.Value = currentCard.HP;
                NudSTR.Value = currentCard.STR;
                NudAP.Value = currentCard.AP;
                cBRarities.SelectedIndex = (int)currentCard.Rarity;
                cBFactions.SelectedIndex = GetFactionIndex(currentCard.Faction);
            }
        }

        public CardInfoPage(IEnumerable<Faction> factions)
        {
            InitializeComponent();
            cBRarities.DataSource = System.Enum.GetValues(typeof(Rarity));
            if (cBRarities.Items.Count > 0)
            {
                cBRarities.SelectedIndex = 0;
            }

            cBFactions.Items.AddRange(factions.ToArray());
        }

        private void CardInfoPage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

