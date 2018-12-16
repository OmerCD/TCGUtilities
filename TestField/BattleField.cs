using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestField
{
    public enum TurnInfo
    {
        Player1,
        Player2
    }
    public partial class BattleField : Form
    {
        private const int BOARD_WIDTH = 7;
        private const int BOARD_HEIGHT = 6;
        private const int CARD_WIDTH = 100;
        private const int CARD_HEIGHT = 140;
        private const int CARD_MARGIN_WIDTH = 6;
        private const int CARD_MARGIN_HEIGHT = 1;

        private readonly Color[] COLORS = { Color.DeepPink, Color.Yellow, Color.SeaGreen, Color.DarkSeaGreen, Color.Tomato, Color.Brown, Color.DeepSkyBlue };

        private TurnInfo _currentTurn = TurnInfo.Player1;
        Color _player1Color = Color.Crimson;
        Color _player2Color = Color.DarkBlue;


        private int Player1Gold
        {
            get => (int)nUDPlayer1Gold.Value;
            set => nUDPlayer1Gold.Value = value;
        }
        private int Player2Gold
        {
            get => (int)nUDPlayer2Gold.Value;
            set => nUDPlayer2Gold.Value = value;
        }

        public BattleField()
        {
            InitializeComponent();
            fLPField.MinimumSize = fLPField.MaximumSize = new Size((CARD_WIDTH + CARD_MARGIN_WIDTH * 2) * BOARD_WIDTH, (CARD_HEIGHT + CARD_MARGIN_HEIGHT * 2) * BOARD_HEIGHT);
        }

        private void BattleField_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < BOARD_WIDTH; j++)
                {
                    var pB = new PictureBox
                    {
                        Size = new Size(CARD_WIDTH, CARD_HEIGHT),
                        Tag = i,
                        Margin = new Padding(CARD_MARGIN_WIDTH, CARD_MARGIN_HEIGHT, CARD_MARGIN_WIDTH, CARD_MARGIN_HEIGHT),
                    };

                    if (i == 0 || i == BOARD_HEIGHT - 1)
                    {
                        pB.BackColor = Color.Gray;
                    }
                    else
                    {
                        pB.ForeColor = pB.BackColor = COLORS[j];
                        pB.ContextMenuStrip = cMSCardAction;
                    }
                    fLPField.Controls.Add(pB);
                }
            }
        }

        private int CalculateMoneyEndTurn()
        {
            int indexBuffer = 0;
            int moneyGranted = 0;
            Color controlColor;
            if (_currentTurn == TurnInfo.Player1)
            {
                indexBuffer = BOARD_HEIGHT-1;
                controlColor = _player1Color;
            }
            else
            {
                controlColor = _player2Color;
            }
            foreach (PictureBox pictureBox in fLPField.Controls)
            {
                if (pictureBox.BackColor == controlColor)
                {
                    moneyGranted += Math.Abs(indexBuffer - (int) pictureBox.Tag) * 25;
                }
            }

            return moneyGranted;
        }
        private void EndTurn_Click(object sender, EventArgs e)
        {
            if (_currentTurn == TurnInfo.Player1)
            {
                gBPlayer1.BackColor = SystemColors.Control;
                gBPlayer2.BackColor = Color.Aqua;
                Player1Gold += CalculateMoneyEndTurn();
                _currentTurn = TurnInfo.Player2;
            }
            else
            {
                gBPlayer2.BackColor = SystemColors.Control;
                gBPlayer1.BackColor = Color.Aqua;
                Player2Gold += CalculateMoneyEndTurn();
                _currentTurn = TurnInfo.Player1;
            }
        }

        private bool BuyUnit(int cost)
        {
            if (_currentTurn == TurnInfo.Player1)
            {
                if (Player1Gold >= cost)
                {
                    Player1Gold -= cost;
                    return true;
                }

                return false;
            }
            else if (_currentTurn == TurnInfo.Player2)
            {
                if (Player2Gold >= cost)
                {
                    Player2Gold -= cost;
                    return true;
                }

                return false;
            }
            else
            {
                throw new IndexOutOfRangeException("Could not find that. But how? " + _currentTurn);
            }
        }
        private void UnitCost_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                var pB = cMSCardAction.SourceControl;
                e.SuppressKeyPress = true;
                cMSCardAction.Close();
                if (int.TryParse(tSTBUnitCost.Text, out var costResult))
                {
                    if (BuyUnit(costResult))
                    {
                        if (_currentTurn == TurnInfo.Player1)
                        {
                            pB.BackColor = _player1Color;
                        }
                        else if (_currentTurn == TurnInfo.Player2)
                        {
                            pB.BackColor = _player2Color;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You are out of your element");
                    }
                }
                else
                {
                    MessageBox.Show("Are you an idiot?");
                }
                tSTBUnitCost.Text = string.Empty;
            }
        }

        private void RemoveCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pB = cMSCardAction.SourceControl;
            pB.BackColor = pB.ForeColor;
        }
    }
}
