using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1WaterBalloons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // display a set of instructions
        // button to close instructions and play game 
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Show how to play form
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // open form with game
            Form3 f3 = new Form3();
            f3.ShowDialog();
            // close this form
            this.Close();
        }
    }
}
