using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlip
{
    public partial class Form1 : Form
    {

        // Array of coins
        Coin[] coins = new Coin[5];

        public Form1()
        {
            InitializeComponent();
        }
        
        // the function that starts when the form is displayed for the first time
        // initiation point 
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";

            for (int i = 0; i < coins.Length; i++)
            {
                coins[i] = new Coin(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // change label into 5 heads or tails
            label1.Text = "";
            Random rnd = new Random();
            for (int i = 0; i < coins.Length; i++)
            {
                label1.Text += coins[i].isHeads + ", ";
                coins[i].flipCoin(rnd);
            }
            // set the pictures according to isHeads field
            pictureBox1.Image= coins[0].isHeads? Properties.Resources.quarterHeads1 : Properties.Resources.quarterTails;
            pictureBox2.Image = coins[1].isHeads ? Properties.Resources.quarterHeads1 : Properties.Resources.quarterTails;
            pictureBox3.Image = coins[2].isHeads ? Properties.Resources.quarterHeads1 : Properties.Resources.quarterTails;
            pictureBox4.Image = coins[3].isHeads ? Properties.Resources.quarterHeads1 : Properties.Resources.quarterTails;
            pictureBox5.Image = coins[4].isHeads ? Properties.Resources.quarterHeads1 : Properties.Resources.quarterTails;

        }
    }
}
