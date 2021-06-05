using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContactTracing
{
    public partial class ContactTracing_form : Form
    {
        public ContactTracing_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enter_btn_Click(object sender, EventArgs e)
        {

            StreamWriter outputFile = new StreamWriter(Application.StartupPath + "\\Informations\\" + "customerDetails.txt"); ;
            outputFile.WriteLine(label_name.Text + " " + firstName_bx.Text + " " + middleName_bx.Text + " " + surName_bx.Text);
            outputFile.WriteLine(label_Age.Text + " " + age_bx.Text);
            outputFile.WriteLine(label_phoneNum + " " + phone_bx);
            outputFile.WriteLine(label_email + " " + email_bx);
            outputFile.WriteLine(label_add + " " + add_bx);
            outputFile.WriteLine(label_zipCode + " " + zipCode_bx);
            outputFile.WriteLine();
            outputFile.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void piktyur_Click(object sender, EventArgs e)
        {

        }
    }
}
