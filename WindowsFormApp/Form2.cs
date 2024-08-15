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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Form1 frm;

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Show();
            //Application.Exit();
            frm.ClearForm();
        }

        /// <summary>
        /// Welcomes user with their usernames.
        /// </summary>
        /// <param name="username">string username</param>
        public void WelcomeUser(string username)
        {
            lblUsername.Text = "Welcome, " + username;
        }

        /// <summary>
        /// Welcomes user with their usernames. It transmits the information of the form being called
        /// </summary>
        /// <param name="username">string username</param>
        /// <param name="incomingForm">Form1 formVariable</param>
        public void WelcomeUser(string username, Form1 incomingForm) // Aynı isim: overload method
        {
            lblUsername.Text = "Welcome, " + username;
            frm = incomingForm;
        }
    }
}
