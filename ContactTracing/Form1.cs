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
        }
        private void enter_btn_Click(object sender, EventArgs e)
        {
            if (checkBox_confirm.CheckState == CheckState.Checked)
            {
                if (travel_options.SelectedItem == "Yes")
                {
                    if (surName_bx.Text == "" || firstName_bx.Text == "" || age_bx.SelectedItem == null || sex_options.SelectedItem == null || temp_bx.Text == "" || add_bx.Text == "" || phone_bx.Text == ""
                || travel_options.SelectedItem == null || place_trvl_bx.Text == "") //all NULL and placeTravelBox
                    {
                        MessageBox.Show("Please fill up all required fields!");
                    }
                    else //all data will proceed in the file text
                    {
                        ImportantInfo();
                        dataCompleted_message();
                    }
                }
                if (travel_options.SelectedItem == "No") //all NULL w/o placeTravelBox
                {
                    if (surName_bx.Text == "" || firstName_bx.Text == "" || age_bx.SelectedItem == null || sex_options.SelectedItem == null || temp_bx.Text == "" || add_bx.Text == "" || phone_bx.Text == ""
                || travel_options.SelectedItem == null)
                    {
                        MessageBox.Show("Please fill up all required fields!");
                    }
                    else //all data will proceed in the file text
                    {
                        ImportantInfo();
                        dataCompleted_message();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill up all required fields!");
            }
            
        }
        private void ContactTracing_form_Load(object sender, EventArgs e)
        {
            //Added Options
            travel_options.Items.Clear();
            travel_options.Items.Add("Yes");
            travel_options.Items.Add("No");
            //
            sex_options.Items.Clear();
            sex_options.Items.Add("Female");
            sex_options.Items.Add("Male");
            sex_options.Items.Add("prefer not to say");
            //
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
        //================================PRIVATE VOIDS (made)
        private void dataCompleted_message()
        {
            string message = "Thank you for filling up " + firstName_bx.Text + "!";
            MessageBox.Show(message);
            Application.Exit();
        }
        private void ImportantInfo()
        {
            StreamWriter outputFile = File.AppendText("customerDetails.txt");
            outputFile.WriteLine(DateTime.Now);
            outputFile.WriteLine("======================================================");
            outputFile.WriteLine(label_name.Text + " " + firstName_bx.Text + " " + middleName_bx.Text + " " + surName_bx.Text);
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

        private void phone_bx_MouseClick(object sender, MouseEventArgs e)
        {
            phone_bx.Clear();
        }
    }
}

