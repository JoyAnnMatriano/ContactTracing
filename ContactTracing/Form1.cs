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
            place_trvl.Visible = false;
            place_trvl_bx.Visible = false;

            submit_btn.Enabled = false;
        }
        private void enter_btn_Click(object sender, EventArgs e)
        {
            ImportantInfo(firstName_bx.Text, middleName_bx.Text, surName_bx.Text, byte.Parse(age_bx.Text));

            dataCompleted_message();
        }
        private void ContactTracing_form_Load(object sender, EventArgs e)
        {
            travel_options.Items.Clear();
            travel_options.Items.Add("Yes");
            travel_options.Items.Add("No");

            sex_options.Items.Clear();
            sex_options.Items.Add("Female");
            sex_options.Items.Add("Male");
            sex_options.Items.Add("prefer not to say");

            age_bx.Items.Clear();
            age_bx.Items.Add("15");
            age_bx.Items.Add("16");
            age_bx.Items.Add("17");
            age_bx.Items.Add("18");
            age_bx.Items.Add("19");
            age_bx.Items.Add("20");
            age_bx.Items.Add("21");
            age_bx.Items.Add("22");
            age_bx.Items.Add("23");
            age_bx.Items.Add("24");
            age_bx.Items.Add("25");
            age_bx.Items.Add("26");
            age_bx.Items.Add("27");
            age_bx.Items.Add("28");
            age_bx.Items.Add("29");
            age_bx.Items.Add("30");
            age_bx.Items.Add("31");
            age_bx.Items.Add("32");
            age_bx.Items.Add("33");
            age_bx.Items.Add("34");
            age_bx.Items.Add("35");
            age_bx.Items.Add("36");
            age_bx.Items.Add("37");
            age_bx.Items.Add("38");
            age_bx.Items.Add("39");
            age_bx.Items.Add("40");
            age_bx.Items.Add("41");
            age_bx.Items.Add("42");
            age_bx.Items.Add("43");
            age_bx.Items.Add("44");
            age_bx.Items.Add("45");
            age_bx.Items.Add("46");
            age_bx.Items.Add("47");
            age_bx.Items.Add("48");
            age_bx.Items.Add("49");
            age_bx.Items.Add("50");
            age_bx.Items.Add("51");
            age_bx.Items.Add("52");
            age_bx.Items.Add("53");
            age_bx.Items.Add("54");
            age_bx.Items.Add("55");
            age_bx.Items.Add("56");
            age_bx.Items.Add("57");
            age_bx.Items.Add("58");
            age_bx.Items.Add("59");
            age_bx.Items.Add("60");
            age_bx.Items.Add("61");
            age_bx.Items.Add("62");
            age_bx.Items.Add("63");
            age_bx.Items.Add("64");
            age_bx.Items.Add("65");
        }
        private void ImportantInfo(string firstName, string middleName, string surName, byte age)
        {
            StreamWriter outputFile = File.AppendText("customerDetails.txt");
            outputFile.WriteLine(DateTime.Now);
            outputFile.WriteLine("======================================================");
            outputFile.WriteLine(label_name.Text + " " + firstName + " " + middleName + " " + surName);
            outputFile.WriteLine($"Age: {age_bx.SelectedItem}");
            outputFile.WriteLine("Phone Number: " + phone_bx.Text);
            outputFile.WriteLine("Email: " + email_bx.Text);
            outputFile.WriteLine("Address: " + add_bx.Text);
            outputFile.WriteLine($"Sex: {sex_options.SelectedItem}");
            outputFile.WriteLine($"Did the customer travelled?: {travel_options.SelectedItem}");
            outputFile.WriteLine($"(if YES) Place(s): {place_trvl_bx.Text}");
            outputFile.WriteLine("Customer not experiencing any COVID 19 symptoms: Checked");
            outputFile.WriteLine("=======================================================");
            outputFile.Close();
        }
        private void travel_options_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (travel_options.SelectedItem == "Yes")
            {
                place_trvl.Visible = true;
                place_trvl_bx.Visible = true;
            }
            else
            {
                place_trvl.Visible = false;
                place_trvl_bx.Visible = false;
            }
            EnableSubmitbtn();
        }
        private void redHighlight()
        {
            if (surName_bx.Text == "" || firstName_bx.Text == "")
            {
                MessageBox.Show("Please input your complete name");
            }
            if (age_bx.Text == "" || phone_bx.Text == "" || add_bx.Text == "")
            {
                MessageBox.Show("Please input all the required fields");
            }
            if (checkBox_confirm.CheckState == CheckState.Indeterminate)
            {
                checkBox_confirm.ForeColor = Color.Red;
            }
        }
        private void view_btn_click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Join(Environment.NewLine,
                                                     label_name.Text + " " + (firstName_bx).Text + " " + (middleName_bx).Text + " " + (surName_bx).Text,
                                                     $"Age: {age_bx.SelectedItem} ",
                                                     "Phone Number: " + phone_bx.Text,
                                                     "Email: " + email_bx.Text,
                                                     "Address: " + add_bx.Text,
                                                     $"Sex: {sex_options.SelectedItem}",
                                                     $"Did the customer travelled?: {travel_options.SelectedItem}",
                                                     $"(if YES) Place(s): {place_trvl_bx.Text}"));
        }
        private void dataCompleted_message()
        {
            string message = "Thank you for filling up " + firstName_bx.Text + "!";
            MessageBox.Show(message);
            Application.Exit();
        }
        private void EnableSubmitbtn()
        {
            if (surName_bx.Text == "")
            {
            }
           
        }
        private void count_x()
        {
            int x_count = 10;
            if (surName_bx.Text == "")
            {
                --x_count;
            }
            if (firstName_bx.Text == "")
            {
                --x_count;
            }
            if (age_bx.SelectedItem == null)
            {
                --x_count;
            }
            if (sex_options.SelectedItem == null)
            {
                --x_count;
            }
            if (temp_bx.Text == "")
            {
                --x_count;
            }
            if (add_bx.Text == "")
            {
                --x_count;
            }
            if (phone_bx.Text == "")
            {
                --x_count;
            }
            if (checkBox_confirm.CheckState == CheckState.Indeterminate)
            {
                --x_count;
            }
        }
    }
}

