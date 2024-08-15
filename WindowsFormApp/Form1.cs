namespace WindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> usernames = new List<string>();
        string password = "123456";

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';

            usernames.Add("admin");
            usernames.Add("user");
            usernames.Add("systemUser");
            usernames.Add("network");
            usernames.Add("powerUser");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {

                // Methoddaki local deðiþkenlere _ koyabiliriz.
                string _username = txtUsername.Text.Trim();
                string _password = txtPassword.Text.Trim();

                if (usernames.Contains(_username) && password.Contains(_password))
                {
                    Form2 frm = new Form2();
                    //frm.ShowDialog();
                    frm.Show(); // form2 açmak için yapýyorum

                    //this.Close(); // form1'i kapatýr, bellekten siler (main'de bu olduðu için tüm form kapanýr)
                    this.Hide(); // form1'in görünmesini engeller, bellekte durur. form2 açýlýr bu kez

                    //frm.WelcomeUser(_username);
                    frm.WelcomeUser(_username, this); // this: Form1

                    //frm.lblUsername.Text = "Welcome, " + _username;
                }
                else
                {
                    //DialogResult bir primitive veri tipi gibidir. Týklanan button'a göre bir þeyler yapabilirim
                    DialogResult result = MessageBox.Show("Username or password wrong!", "Warning Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        txtUsername.Text = "";
                        //txtUsername.Clear(); Yukarýdaki gibi
                        txtPassword.Text = "";
                        txtUsername.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter your username and password", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkShowPassword.Checked)
            {
                txtPassword.PasswordChar = default;
            } 
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        public void ClearForm()
        {
            txtUsername.Clear();
            txtUsername.Focus();
            txtPassword.Clear();
        }
    }
}
