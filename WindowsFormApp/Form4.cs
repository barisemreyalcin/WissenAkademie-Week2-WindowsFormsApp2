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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        List<string> fullNameList = new List<string>();
        List<string> idNoList = new List<string>();
        List<string> cityList = new List<string>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsThereEmptyInput())
            {
                MessageBox.Show("Please, fill all the inputs");
            }
            else
            {
                fullNameList.Add(txtFullName.Text);
                idNoList.Add(txtIdNo.Text);
                cityList.Add(txtCity.Text);

                ClearInputs();
            }
        }

        private bool IsThereEmptyInput()
        {
            foreach (Control item in grpAddPersonnel.Controls) // 9 tane Control türünde geliyor, TextBox'a boxing unboxing yapmalıyız
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    if (txt.Text == "") return true;
                }
            }

            return false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            foreach (Control item in grpAddPersonnel.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txt = (TextBox)item; // Sadece adresi reference type'tan alıp primitive olarak tutuyorum
                    // Biri Control veri tipinde box edilmiş durumda, unboxing işlemi ile TextBox tipinde tutulmaya çalışılıyor
                    txt.Clear();
                }
            }
            txtFullName.Focus();
        }

        private void btnShowArchive_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.SendData(fullNameList, idNoList, cityList, this);
            frm.ShowDialog();
            int lineNum = int.Parse(txtFullName.Tag.ToString());
            int index = lineNum - 1;

            txtFullName.Text = fullNameList[index];
            txtIdNo.Text = idNoList[index];
            txtCity.Text = cityList[index];
        }
    }
}
