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
    public partial class Form3_for_Rules : Form
    {
        public Form3_for_Rules()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 gamemenu = new Form1();
            gamemenu.Show();
        }
    }
}
