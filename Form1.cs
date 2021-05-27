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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Playbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 gameForm = new Form2();
            gameForm.Show();

        }

        private void Buttonquit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 gameForm = new Form2();
            gameForm.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();      
            Form3_for_Rules gamerules = new Form3_for_Rules();
            gamerules.Show();

        }
    }
}
