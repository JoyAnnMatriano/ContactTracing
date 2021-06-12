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

        private void enter_btn_Click(object sender, EventArgs e)
        {
            ImportantInfo(firstName_bx.Text, middleName_bx.Text, surName_bx.Text, byte.Parse(age_bx.Text));
        }

        private void ContactTracing_form_Load(object sender, EventArgs e)
        {
            confirmbx_dropdown.Items.Add("Yes");
            confirmbx_dropdown.Items.Add("No");
            confirmbx_dropdown.Items.Add("I am not sure");
        }

        private void ImportantInfo(string firstName, string middleName, string surName, byte age)
        {
            StreamWriter outputFile = new StreamWriter(Application.StartupPath + "\\Informations\\" + "customerDetails.txt"); ;
            outputFile.WriteLine(label_name.Text + " " + firstName + " " + middleName + " " + surName);
            outputFile.WriteLine(label_Age.Text + " " + age_bx.ToString());
            outputFile.WriteLine(label_phoneNum + " " + phone_bx);
            outputFile.WriteLine(label_email + " " + email_bx);
            outputFile.WriteLine(label_add + " " + add_bx);
            outputFile.WriteLine(label_zipCode + " " + zipCode_bx);
            outputFile.WriteLine();
            outputFile.Close();
        }
    }
}
