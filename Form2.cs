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
        private void Restartbutton_Click(object sender, EventArgs e)
        {

        }

        private void Box1_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[0] = returnSymbol(currentTurn);
            box1.Text = gameboard[0];
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Box2_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[1] = returnSymbol(currentTurn);
            box2.Text = gameboard[1];
        }

        private void Box3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[2] = returnSymbol(currentTurn);
            box3.Text = gameboard[2];
        }

        private void Box4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[3] = returnSymbol(currentTurn);
            box4.Text = gameboard[3];
        }

        private void Box5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[4] = returnSymbol(currentTurn);
            box5.Text = gameboard[4];
        }

        private void Box6_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[5] = returnSymbol(currentTurn);
            box6.Text = gameboard[5];
        }

        private void Box7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[6] = returnSymbol(currentTurn);
            box7.Text = gameboard[6];
        }

        private void Box8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[7] = returnSymbol(currentTurn);
            box8.Text = gameboard[7];
        }

        private void Box9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[8] = returnSymbol(currentTurn);
            box9.Text = gameboard[8];
        }
    }
}


    
