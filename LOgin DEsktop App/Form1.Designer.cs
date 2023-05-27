namespace LOgin_DEsktop_App
{
    partial class Form1
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
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTelNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.radioBtFamale = new System.Windows.Forms.RadioButton();
            this.radioBtMale = new System.Windows.Forms.RadioButton();
            this.labelGender = new System.Windows.Forms.Label();
            this.dateTimePickerBith = new System.Windows.Forms.DateTimePicker();
            this.labelBithDate = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCounty = new System.Windows.Forms.TextBox();
            this.labelCounty = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(110, 26);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.PlaceholderText = "Name";
            this.textBoxSearchName.Size = new System.Drawing.Size(121, 23);
            this.textBoxSearchName.TabIndex = 7;
            this.textBoxSearchName.TextChanged += new System.EventHandler(this.textBoxSearchName_TextChanged);
            // 
            // labelSearchName
            // 
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.BackColor = System.Drawing.Color.White;
            this.labelSearchName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSearchName.Location = new System.Drawing.Point(110, 8);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(76, 15);
            this.labelSearchName.TabIndex = 1;
            this.labelSearchName.Text = "Search name";
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonLoad.Enabled = false;
            this.buttonLoad.Location = new System.Drawing.Point(345, 26);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::LOgin_DEsktop_App.Properties.Resources._1236485;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.textBoxTelNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.radioBtFamale);
            this.groupBox1.Controls.Add(this.radioBtMale);
            this.groupBox1.Controls.Add(this.labelGender);
            this.groupBox1.Controls.Add(this.dateTimePickerBith);
            this.groupBox1.Controls.Add(this.labelBithDate);
            this.groupBox1.Controls.Add(this.textBoxCity);
            this.groupBox1.Controls.Add(this.labelCity);
            this.groupBox1.Controls.Add(this.textBoxCounty);
            this.groupBox1.Controls.Add(this.labelCounty);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.textBoxSurname);
            this.groupBox1.Controls.Add(this.labelSurname);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(110, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 334);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anket";
            // 
            // textBoxTelNum
            // 
            this.textBoxTelNum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTelNum.Location = new System.Drawing.Point(81, 184);
            this.textBoxTelNum.Name = "textBoxTelNum";
            this.textBoxTelNum.PlaceholderText = "+994xxxxxxxx";
            this.textBoxTelNum.Size = new System.Drawing.Size(223, 23);
            this.textBoxTelNum.TabIndex = 7;
            this.textBoxTelNum.TextChanged += new System.EventHandler(this.textBoxTelNum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tel number";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(81, 305);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(135, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // radioBtFamale
            // 
            this.radioBtFamale.AutoSize = true;
            this.radioBtFamale.BackColor = System.Drawing.Color.White;
            this.radioBtFamale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtFamale.Location = new System.Drawing.Point(143, 251);
            this.radioBtFamale.Name = "radioBtFamale";
            this.radioBtFamale.Size = new System.Drawing.Size(63, 19);
            this.radioBtFamale.TabIndex = 10;
            this.radioBtFamale.TabStop = true;
            this.radioBtFamale.Text = "Female";
            this.radioBtFamale.UseVisualStyleBackColor = false;
            // 
            // radioBtMale
            // 
            this.radioBtMale.AutoSize = true;
            this.radioBtMale.BackColor = System.Drawing.Color.White;
            this.radioBtMale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtMale.Location = new System.Drawing.Point(81, 251);
            this.radioBtMale.Name = "radioBtMale";
            this.radioBtMale.Size = new System.Drawing.Size(51, 19);
            this.radioBtMale.TabIndex = 1;
            this.radioBtMale.TabStop = true;
            this.radioBtMale.Text = "Male";
            this.radioBtMale.UseVisualStyleBackColor = false;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.White;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGender.Location = new System.Drawing.Point(6, 255);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(45, 15);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender";
            // 
            // dateTimePickerBith
            // 
            this.dateTimePickerBith.Location = new System.Drawing.Point(81, 217);
            this.dateTimePickerBith.Name = "dateTimePickerBith";
            this.dateTimePickerBith.Size = new System.Drawing.Size(223, 23);
            this.dateTimePickerBith.TabIndex = 8;
            this.dateTimePickerBith.ValueChanged += new System.EventHandler(this.dateTimePickerBith_ValueChanged);
            // 
            // labelBithDate
            // 
            this.labelBithDate.AutoSize = true;
            this.labelBithDate.BackColor = System.Drawing.Color.White;
            this.labelBithDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBithDate.Location = new System.Drawing.Point(6, 225);
            this.labelBithDate.Name = "labelBithDate";
            this.labelBithDate.Size = new System.Drawing.Size(58, 15);
            this.labelBithDate.TabIndex = 4;
            this.labelBithDate.Text = "Birth date";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCity.Location = new System.Drawing.Point(81, 143);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.PlaceholderText = "City";
            this.textBoxCity.Size = new System.Drawing.Size(223, 23);
            this.textBoxCity.TabIndex = 6;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.White;
            this.labelCity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCity.Location = new System.Drawing.Point(6, 146);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 15);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "City";
            // 
            // textBoxCounty
            // 
            this.textBoxCounty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCounty.Location = new System.Drawing.Point(81, 109);
            this.textBoxCounty.Name = "textBoxCounty";
            this.textBoxCounty.PlaceholderText = "Country";
            this.textBoxCounty.Size = new System.Drawing.Size(223, 23);
            this.textBoxCounty.TabIndex = 5;
            this.textBoxCounty.TextChanged += new System.EventHandler(this.textBoxCounty_TextChanged);
            // 
            // labelCounty
            // 
            this.labelCounty.AutoSize = true;
            this.labelCounty.BackColor = System.Drawing.Color.White;
            this.labelCounty.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCounty.Location = new System.Drawing.Point(6, 112);
            this.labelCounty.Name = "labelCounty";
            this.labelCounty.Size = new System.Drawing.Size(49, 15);
            this.labelCounty.TabIndex = 4;
            this.labelCounty.Text = "Country";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(81, 57);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Name";
            this.textBoxName.Size = new System.Drawing.Size(223, 23);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.White;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(6, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSurname.Location = new System.Drawing.Point(81, 26);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.PlaceholderText = "Surname";
            this.textBoxSurname.Size = new System.Drawing.Size(223, 23);
            this.textBoxSurname.TabIndex = 3;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.BackColor = System.Drawing.Color.White;
            this.labelSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSurname.Location = new System.Drawing.Point(6, 29);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(55, 15);
            this.labelSurname.TabIndex = 4;
            this.labelSurname.Text = "Surname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::LOgin_DEsktop_App.Properties.Resources.desktop_wallpaper_website_background_website_login_page_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.labelSearchName);
            this.Controls.Add(this.textBoxSearchName);
            this.Name = "Form1";
            this.Text = "Anket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxSearchName;
        private Label labelSearchName;
        private Button buttonLoad;
        private GroupBox groupBox1;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBoxSurname;
        private Label labelSurname;
        private TextBox textBoxCounty;
        private Label labelCounty;
        private RadioButton radioBtFamale;
        private RadioButton radioBtMale;
        private Label labelGender;
        private DateTimePicker dateTimePickerBith;
        private Label labelBithDate;
        private TextBox textBoxCity;
        private Label labelCity;
        private Button buttonSave;
        private TextBox textBoxTelNum;
        private Label label1;
    }
}