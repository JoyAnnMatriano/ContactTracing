
namespace ContactTracing
{
    partial class ContactTracing_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactTracing_form));
            this.submit_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.surName_bx = new System.Windows.Forms.TextBox();
            this.age_bx = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.firstName_bx = new System.Windows.Forms.TextBox();
            this.middleName_bx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Age = new System.Windows.Forms.Label();
            this.label_phoneNum = new System.Windows.Forms.Label();
            this.phone_bx = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.email_bx = new System.Windows.Forms.TextBox();
            this.label_add = new System.Windows.Forms.Label();
            this.add_bx = new System.Windows.Forms.TextBox();
            this.label_zipCode = new System.Windows.Forms.Label();
            this.zipCode_bx = new System.Windows.Forms.TextBox();
            this.label_confirmation1 = new System.Windows.Forms.Label();
            this.label_confirmation2 = new System.Windows.Forms.Label();
            this.label_confirmation3 = new System.Windows.Forms.Label();
            this.label_confirmation4 = new System.Windows.Forms.Label();
            this.label_confirmation5 = new System.Windows.Forms.Label();
            this.label_confirmation6 = new System.Windows.Forms.Label();
            this.label_confirmation7 = new System.Windows.Forms.Label();
            this.bg_color = new System.Windows.Forms.Panel();
            this.place_trvl = new System.Windows.Forms.Label();
            this.travel_options = new System.Windows.Forms.ComboBox();
            this.confirmbx_dropdown = new System.Windows.Forms.ComboBox();
            this.place_trvl_bx = new System.Windows.Forms.TextBox();
            this.travel_lbl = new System.Windows.Forms.Label();
            this.bg_color.SuspendLayout();
            this.SuspendLayout();
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(206, 494);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(215, 49);
            this.submit_btn.TabIndex = 0;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(345, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // surName_bx
            // 
            this.surName_bx.Location = new System.Drawing.Point(97, 116);
            this.surName_bx.Name = "surName_bx";
            this.surName_bx.Size = new System.Drawing.Size(127, 23);
            this.surName_bx.TabIndex = 2;
            // 
            // age_bx
            // 
            this.age_bx.Location = new System.Drawing.Point(97, 166);
            this.age_bx.Name = "age_bx";
            this.age_bx.Size = new System.Drawing.Size(53, 23);
            this.age_bx.TabIndex = 2;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label_name.Location = new System.Drawing.Point(49, 124);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(42, 15);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "Name:";
            // 
            // firstName_bx
            // 
            this.firstName_bx.Location = new System.Drawing.Point(230, 116);
            this.firstName_bx.Name = "firstName_bx";
            this.firstName_bx.Size = new System.Drawing.Size(127, 23);
            this.firstName_bx.TabIndex = 2;
            // 
            // middleName_bx
            // 
            this.middleName_bx.Location = new System.Drawing.Point(363, 116);
            this.middleName_bx.Name = "middleName_bx";
            this.middleName_bx.Size = new System.Drawing.Size(127, 23);
            this.middleName_bx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(128, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "SURNAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Location = new System.Drawing.Point(260, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "FIRST NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Location = new System.Drawing.Point(386, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "MIDDLE INITIAL";
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label_Age.Location = new System.Drawing.Point(49, 174);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(31, 15);
            this.label_Age.TabIndex = 3;
            this.label_Age.Text = "Age:";
            // 
            // label_phoneNum
            // 
            this.label_phoneNum.AutoSize = true;
            this.label_phoneNum.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label_phoneNum.Location = new System.Drawing.Point(156, 169);
            this.label_phoneNum.Name = "label_phoneNum";
            this.label_phoneNum.Size = new System.Drawing.Size(91, 15);
            this.label_phoneNum.TabIndex = 3;
            this.label_phoneNum.Text = "Phone Number:";
            // 
            // phone_bx
            // 
            this.phone_bx.Location = new System.Drawing.Point(250, 166);
            this.phone_bx.Name = "phone_bx";
            this.phone_bx.Size = new System.Drawing.Size(240, 23);
            this.phone_bx.TabIndex = 2;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label_email.Location = new System.Drawing.Point(49, 203);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(39, 15);
            this.label_email.TabIndex = 3;
            this.label_email.Text = "Email:";
            // 
            // email_bx
            // 
            this.email_bx.Location = new System.Drawing.Point(97, 198);
            this.email_bx.Name = "email_bx";
            this.email_bx.Size = new System.Drawing.Size(393, 23);
            this.email_bx.TabIndex = 2;
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label_add.Location = new System.Drawing.Point(42, 235);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(52, 15);
            this.label_add.TabIndex = 3;
            this.label_add.Text = "Address:";
            // 
            // add_bx
            // 
            this.add_bx.Location = new System.Drawing.Point(97, 230);
            this.add_bx.Name = "add_bx";
            this.add_bx.Size = new System.Drawing.Size(250, 23);
            this.add_bx.TabIndex = 2;
            // 
            // label_zipCode
            // 
            this.label_zipCode.AutoSize = true;
            this.label_zipCode.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label_zipCode.Location = new System.Drawing.Point(363, 233);
            this.label_zipCode.Name = "label_zipCode";
            this.label_zipCode.Size = new System.Drawing.Size(58, 15);
            this.label_zipCode.TabIndex = 3;
            this.label_zipCode.Text = "Zip Code:";
            // 
            // zipCode_bx
            // 
            this.zipCode_bx.Location = new System.Drawing.Point(430, 230);
            this.zipCode_bx.Name = "zipCode_bx";
            this.zipCode_bx.Size = new System.Drawing.Size(60, 23);
            this.zipCode_bx.TabIndex = 2;
            // 
            // label_confirmation1
            // 
            this.label_confirmation1.AutoSize = true;
            this.label_confirmation1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label_confirmation1.Location = new System.Drawing.Point(42, 348);
            this.label_confirmation1.Name = "label_confirmation1";
            this.label_confirmation1.Size = new System.Drawing.Size(119, 15);
            this.label_confirmation1.TabIndex = 3;
            this.label_confirmation1.Text = "I confirm that I or my";
            // 
            // label_confirmation2
            // 
            this.label_confirmation2.AutoSize = true;
            this.label_confirmation2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label_confirmation2.Location = new System.Drawing.Point(42, 363);
            this.label_confirmation2.Name = "label_confirmation2";
            this.label_confirmation2.Size = new System.Drawing.Size(139, 15);
            this.label_confirmation2.TabIndex = 3;
            this.label_confirmation2.Text = "household member have";
            // 
            // label_confirmation3
            // 
            this.label_confirmation3.AutoSize = true;
            this.label_confirmation3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label_confirmation3.Location = new System.Drawing.Point(42, 378);
            this.label_confirmation3.Name = "label_confirmation3";
            this.label_confirmation3.Size = new System.Drawing.Size(122, 15);
            this.label_confirmation3.TabIndex = 3;
            this.label_confirmation3.Text = "not had COVID-19 OR";
            // 
            // label_confirmation4
            // 
            this.label_confirmation4.AutoSize = true;
            this.label_confirmation4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label_confirmation4.Location = new System.Drawing.Point(42, 393);
            this.label_confirmation4.Name = "label_confirmation4";
            this.label_confirmation4.Size = new System.Drawing.Size(82, 15);
            this.label_confirmation4.TabIndex = 3;
            this.label_confirmation4.Text = "have not been";
            // 
            // label_confirmation5
            // 
            this.label_confirmation5.AutoSize = true;
            this.label_confirmation5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label_confirmation5.Location = new System.Drawing.Point(42, 408);
            this.label_confirmation5.Name = "label_confirmation5";
            this.label_confirmation5.Size = new System.Drawing.Size(97, 15);
            this.label_confirmation5.TabIndex = 3;
            this.label_confirmation5.Text = "experiencing any";
            // 
            // label_confirmation6
            // 
            this.label_confirmation6.AutoSize = true;
            this.label_confirmation6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label_confirmation6.Location = new System.Drawing.Point(42, 423);
            this.label_confirmation6.Name = "label_confirmation6";
            this.label_confirmation6.Size = new System.Drawing.Size(118, 15);
            this.label_confirmation6.TabIndex = 3;
            this.label_confirmation6.Text = "COVID-19 symptoms";
            // 
            // label_confirmation7
            // 
            this.label_confirmation7.AutoSize = true;
            this.label_confirmation7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label_confirmation7.Location = new System.Drawing.Point(156, 423);
            this.label_confirmation7.Name = "label_confirmation7";
            this.label_confirmation7.Size = new System.Drawing.Size(49, 15);
            this.label_confirmation7.TabIndex = 3;
            this.label_confirmation7.Text = "recently";
            // 
            // bg_color
            // 
            this.bg_color.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bg_color.Controls.Add(this.place_trvl);
            this.bg_color.Controls.Add(this.label_zipCode);
            this.bg_color.Controls.Add(this.label3);
            this.bg_color.Controls.Add(this.travel_options);
            this.bg_color.Controls.Add(this.confirmbx_dropdown);
            this.bg_color.Controls.Add(this.label2);
            this.bg_color.Controls.Add(this.label1);
            this.bg_color.Controls.Add(this.label_name);
            this.bg_color.Controls.Add(this.place_trvl_bx);
            this.bg_color.Controls.Add(this.zipCode_bx);
            this.bg_color.Controls.Add(this.submit_btn);
            this.bg_color.Controls.Add(this.firstName_bx);
            this.bg_color.Controls.Add(this.phone_bx);
            this.bg_color.Controls.Add(this.add_bx);
            this.bg_color.Controls.Add(this.label_phoneNum);
            this.bg_color.Controls.Add(this.email_bx);
            this.bg_color.Controls.Add(this.travel_lbl);
            this.bg_color.Controls.Add(this.label_add);
            this.bg_color.Controls.Add(this.surName_bx);
            this.bg_color.Controls.Add(this.label_email);
            this.bg_color.Controls.Add(this.middleName_bx);
            this.bg_color.Controls.Add(this.label_Age);
            this.bg_color.Controls.Add(this.age_bx);
            this.bg_color.Location = new System.Drawing.Point(0, 2);
            this.bg_color.Name = "bg_color";
            this.bg_color.Size = new System.Drawing.Size(566, 583);
            this.bg_color.TabIndex = 6;
            // 
            // place_trvl
            // 
            this.place_trvl.AutoSize = true;
            this.place_trvl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.place_trvl.Location = new System.Drawing.Point(353, 305);
            this.place_trvl.Name = "place_trvl";
            this.place_trvl.Size = new System.Drawing.Size(46, 15);
            this.place_trvl.TabIndex = 3;
            this.place_trvl.Text = "Where?";
            // 
            // travel_options
            // 
            this.travel_options.FormattingEnabled = true;
            this.travel_options.Location = new System.Drawing.Point(246, 302);
            this.travel_options.Name = "travel_options";
            this.travel_options.Size = new System.Drawing.Size(101, 23);
            this.travel_options.TabIndex = 5;
            this.travel_options.SelectedIndexChanged += new System.EventHandler(this.travel_options_SelectedIndexChanged);
            // 
            // confirmbx_dropdown
            // 
            this.confirmbx_dropdown.FormattingEnabled = true;
            this.confirmbx_dropdown.Location = new System.Drawing.Point(246, 353);
            this.confirmbx_dropdown.Name = "confirmbx_dropdown";
            this.confirmbx_dropdown.Size = new System.Drawing.Size(101, 23);
            this.confirmbx_dropdown.TabIndex = 5;
            this.confirmbx_dropdown.SelectedIndexChanged += new System.EventHandler(this.confirmbx_dropdown_SelectedIndexChanged);
            // 
            // place_trvl_bx
            // 
            this.place_trvl_bx.Location = new System.Drawing.Point(405, 302);
            this.place_trvl_bx.Name = "place_trvl_bx";
            this.place_trvl_bx.Size = new System.Drawing.Size(85, 23);
            this.place_trvl_bx.TabIndex = 2;
            // 
            // travel_lbl
            // 
            this.travel_lbl.AutoSize = true;
            this.travel_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.travel_lbl.Location = new System.Drawing.Point(42, 302);
            this.travel_lbl.Name = "travel_lbl";
            this.travel_lbl.Size = new System.Drawing.Size(181, 15);
            this.travel_lbl.TabIndex = 3;
            this.travel_lbl.Text = "Did you travel in the last 14 days?";
            // 
            // ContactTracing_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 553);
            this.Controls.Add(this.label_confirmation7);
            this.Controls.Add(this.label_confirmation6);
            this.Controls.Add(this.label_confirmation5);
            this.Controls.Add(this.label_confirmation4);
            this.Controls.Add(this.label_confirmation3);
            this.Controls.Add(this.label_confirmation2);
            this.Controls.Add(this.label_confirmation1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bg_color);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(582, 626);
            this.Name = "ContactTracing_form";
            this.Text = "Contact Tracing Form";
            this.Load += new System.EventHandler(this.ContactTracing_form_Load);
            this.bg_color.ResumeLayout(false);
            this.bg_color.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox surName_bx;
        private System.Windows.Forms.TextBox age_bx;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox firstName_bx;
        private System.Windows.Forms.TextBox middleName_bx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Age;
        private System.Windows.Forms.Label label_phoneNum;
        private System.Windows.Forms.TextBox phone_bx;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox email_bx;
        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.TextBox add_bx;
        private System.Windows.Forms.Label label_zipCode;
        private System.Windows.Forms.TextBox zipCode_bx;
        private System.Windows.Forms.Label label_confirmation1;
        private System.Windows.Forms.Label label_confirmation2;
        private System.Windows.Forms.Label label_confirmation3;
        private System.Windows.Forms.Label label_confirmation4;
        private System.Windows.Forms.Label label_confirmation5;
        private System.Windows.Forms.Label label_confirmation6;
        private System.Windows.Forms.Label label_confirmation7;
        private System.Windows.Forms.Panel bg_color;
        private System.Windows.Forms.ComboBox confirmbx_dropdown;
        private System.Windows.Forms.ComboBox travel_options;
        private System.Windows.Forms.Label travel_lbl;
        private System.Windows.Forms.Label place_trvl;
        private System.Windows.Forms.TextBox place_trvl_bx;
    }
}

