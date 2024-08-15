using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private Form4 frm;

        internal void SendData(List<string> fullNameList, List<string> idNoList, List<string> cityList, Form4 incomingForm) // Form incomingForm
        {
            int counter = 0;

            foreach (string fullName in fullNameList)
            {
                int lineNumber = counter + 1;
                lvPersonnel.Items.Add(lineNumber.ToString()); // 1. satır 1. sütun (Satıra Items diyoruz)
                lvPersonnel.Items[counter].SubItems.Add(fullNameList[counter]);
                lvPersonnel.Items[counter].SubItems.Add(idNoList[counter]);
                lvPersonnel.Items[counter].SubItems.Add(cityList[counter]);
                counter++;
            }

            frm = incomingForm;
            //frm = (Form4)incomingForm;
        }

        private void lvPersonnel_DoubleClick(object sender, EventArgs e) // sender burada listView
        {
            if (lvPersonnel.Items.Count > 0 && lvPersonnel.SelectedItems.Count > 0)
            {
                // subitems columnları temsil eder
                int lineNum = int.Parse(lvPersonnel.SelectedItems[0].SubItems[0].Text); // ilk kolondaki satır bilgisi
                frm.txtFullName.Tag = lineNum;
                this.Close();
            }
        }
    }
}
