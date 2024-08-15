using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int randomNum;

        private void Form3_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 60;
            btnGuess.Enabled = false;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            timer1.Start();
            randomNum = rnd.Next(1, 101);
            progressBar1.Value = progressBar1.Maximum;
            btnGuess.Enabled = true;
            lblInfo.Text = "";
            lblMsg.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value--;
            btnGuess.Text = "Guess! (" + progressBar1.Value + ")";

            switch (progressBar1.Value)
            {
                case 50:
                    lblMsg.Text = "I think you will lose...";
                    break;
                case 30:
                    lblMsg.Text = "Yes, you will definitely lose!";
                    break;
                case 20:
                    lblMsg.Text = "You are a loser! HAHAHA";

                    ChangeLblMsgStyle();
                    break;
                case 0:
                    lblMsg.Text = "Don't even play again. You were born to fail! LOL";
                    timer1.Stop();
                    ChangeLblMsgStyle();
                    break;
            }
        }

        private void ChangeLblMsgStyle()
        {
            lblMsg.ForeColor = Color.Red;
            lblMsg.Font = new Font(lblMsg.Font, FontStyle.Bold);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int num = 0;
            try
            {
                num = int.Parse(txtEnteredNumber.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lblInfo.Text = num.ToString();

            if (num < randomNum)
            {
                lblInfo.Text += " Too low!";
            }
            else if (num > randomNum)
            {
                lblInfo.Text += " Too high!";
            }
            else
            {
                lblInfo.Text += " Congrats!";
                int secondsPassed = 60 - progressBar1.Value;

                if (secondsPassed > 50 && secondsPassed <= 60)
                {
                    lblMsg.Text = " At the last moment!";
                }
                else if (secondsPassed > 40 && secondsPassed <= 50)
                {
                    lblMsg.Text = " Not so bad!";
                }
                else if (secondsPassed > 30 && secondsPassed <= 40)
                {
                    lblMsg.Text = " It is okay!";
                }
                else if (secondsPassed > 20 && secondsPassed <= 30)
                {
                    lblMsg.Text = " That's good!";
                }
                else if (secondsPassed > 10 && secondsPassed <= 20)
                {
                    lblMsg.Text = " Very good!";
                }
                else if (secondsPassed > 0 && secondsPassed <= 10)
                {
                    lblMsg.Text = " Perfect guess!";
                }
                timer1.Stop();
                btnGuess.Enabled = false;
            }
            txtEnteredNumber.Clear();

        }
    }
}
