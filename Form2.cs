using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        String[] gameboard = new string[9];
        int currentTurn = 0;

        public String returnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }
        public void Winner()
        {
            for (int i = 0; i < 8; i++)
            {
                String pattern = "";

                switch (i)
                {
                    case 0:
                        pattern = gameboard[0] + gameboard[1] + gameboard[2];
                        break;
                    case 1:
                        pattern = gameboard[3] + gameboard[4] + gameboard[5];
                        break;
                    case 2:
                        pattern = gameboard[6] + gameboard[7] + gameboard[8];
                        break;
                    case 3:
                        pattern = gameboard[0] + gameboard[3] + gameboard[6];
                        break;
                    case 4:
                        pattern = gameboard[1] + gameboard[4] + gameboard[7];
                        break;
                    case 5:
                        pattern = gameboard[2] + gameboard[5] + gameboard[8];
                        break;
                    case 6:
                        pattern = gameboard[0] + gameboard[4] + gameboard[8];
                        break;
                    case 7:
                        pattern = gameboard[2] + gameboard[4] + gameboard[6];
                        break;
                }
                if (pattern.Equals("OOO"))
                {
                    reset();
                    MessageBox.Show("Player O has won the game!", "Congratulations!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (pattern.Equals("XXX"))
                {
                    reset();
                    MessageBox.Show("Player X has won the game!", "Congratulations!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                Tie();
            }
        }
        public void reset()
        {
            box1.Text = "";
            box2.Text = "";
            box3.Text = "";
            box4.Text = "";
            box5.Text = "";
            box6.Text = "";
            box7.Text = "";
            box8.Text = "";
            box9.Text = "";
            gameboard = new string[9];
            currentTurn = 0;
        }
        public void Tie()
        {
            int counter = 0;
            for(int i=0; i<gameboard.Length; i++)
            {
                if(gameboard[i] != null) { counter++;}

                if(counter == 9)
                {
                    reset();
                    MessageBox.Show("Intense match!! No winner for today!", "TIE!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void Restartbutton_Click(object sender, EventArgs e)
        {
        }
        private void Box1_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[0] = returnSymbol(currentTurn);
            box1.Text = gameboard[0];
            Winner();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Box2_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[1] = returnSymbol(currentTurn);
            box2.Text = gameboard[1];
            Winner();
        }

        private void Box3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[2] = returnSymbol(currentTurn);
            box3.Text = gameboard[2];
            Winner();
        }
        private void Box4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[3] = returnSymbol(currentTurn);
            box4.Text = gameboard[3];
            Winner();
        }

        private void Box5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[4] = returnSymbol(currentTurn);
            box5.Text = gameboard[4];
            Winner();
        }

        private void Box6_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[5] = returnSymbol(currentTurn);
            box6.Text = gameboard[5];
            Winner();
        }

        private void Box7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[6] = returnSymbol(currentTurn);
            box7.Text = gameboard[6];
            Winner();
        }

        private void Box8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[7] = returnSymbol(currentTurn);
            box8.Text = gameboard[7];
            Winner();
        }

        private void Box9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[8] = returnSymbol(currentTurn);
            box9.Text = gameboard[8];
            Winner();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


    
