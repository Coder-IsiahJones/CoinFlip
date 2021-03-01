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
        // Array of coins.
        Coin[] coins = new Coin[5];
        int headsCount;
        int tailsCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // math random
            Random r = new Random();

            // init
            label1.Text = "";
            headsCount = 0;
            tailsCount = 0;

            // Display label
            for (int i = 0; i < coins.Length; i++)
            {
                //
                coins[i].flipCoin(r);

                //label1.Text += coins[1].isHeads + ",";
                if (coins[i].isHeads == true)
                {
                    headsCount++;
                }
                else
                {
                    tailsCount++;
                }

                // print
                label1.Text = "Heads: " + headsCount + ": " + "Tails: " + tailsCount;

                // winner
                if (headsCount > tailsCount)
                {
                    label2.Text = "Heads win!";
                }
                else
                {
                    label2.Text = "Tails win!";
                }
            }

            // Set pictures.
            pictureBox1.Image = coins[0].isHeads ? Properties.Resources.quarter_heads : Properties.Resources.quarter_tails;
            pictureBox2.Image = coins[1].isHeads ? Properties.Resources.quarter_heads : Properties.Resources.quarter_tails;
            pictureBox3.Image = coins[2].isHeads ? Properties.Resources.quarter_heads : Properties.Resources.quarter_tails;
            pictureBox4.Image = coins[3].isHeads ? Properties.Resources.quarter_heads : Properties.Resources.quarter_tails;
            pictureBox5.Image = coins[4].isHeads ? Properties.Resources.quarter_heads : Properties.Resources.quarter_tails;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // hide at start
            label1.Text = "";
            label2.Text = "";

            // Load coins by default to heads.
            for (int i = 0; i < coins.Length; i++)
            {
                coins[i] = new Coin(true);
            }
            
        }
    }
}
