namespace Mediator
{
    partial class MainWindow
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
            rbPerson = new RadioButton();
            rbFirm = new RadioButton();
            labelFirstName = new Label();
            labelNR = new Label();
            labelName = new Label();
            textBoxFirstName = new TextBox();
            textBoxName = new TextBox();
            textBoxNR = new TextBox();
            textBoxStreet = new TextBox();
            textBoxCity = new TextBox();
            textBoxPostal = new TextBox();
            labelStreet = new Label();
            labelCity = new Label();
            labelPostal = new Label();
            comboBoxCountry = new ComboBox();
            labelCountry = new Label();
            buttonOk = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // rbPerson
            // 
            rbPerson.AutoSize = true;
            rbPerson.Location = new Point(29, 12);
            rbPerson.Name = "rbPerson";
            rbPerson.Size = new Size(168, 29);
            rbPerson.TabIndex = 0;
            rbPerson.TabStop = true;
            rbPerson.Text = "Osoba prywatna";
            rbPerson.UseVisualStyleBackColor = true;
            // 
            // rbFirm
            // 
            rbFirm.AutoSize = true;
            rbFirm.Location = new Point(213, 12);
            rbFirm.Name = "rbFirm";
            rbFirm.Size = new Size(81, 29);
            rbFirm.TabIndex = 1;
            rbFirm.TabStop = true;
            rbFirm.Text = "Firma";
            rbFirm.UseVisualStyleBackColor = true;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFirstName.Location = new Point(96, 65);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(54, 25);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "Imię:";
            // 
            // labelNR
            // 
            labelNR.AutoSize = true;
            labelNR.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNR.Location = new Point(102, 139);
            labelNR.Name = "labelNR";
            labelNR.Size = new Size(48, 25);
            labelNR.TabIndex = 3;
            labelNR.Text = "NIP:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(52, 102);
            labelName.Name = "labelName";
            labelName.Size = new Size(98, 25);
            labelName.TabIndex = 4;
            labelName.Text = "Nazwisko:";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(156, 62);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(221, 31);
            textBoxFirstName.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(156, 99);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(221, 31);
            textBoxName.TabIndex = 6;
            // 
            // textBoxNR
            // 
            textBoxNR.Location = new Point(156, 136);
            textBoxNR.Name = "textBoxNR";
            textBoxNR.Size = new Size(221, 31);
            textBoxNR.TabIndex = 7;
            // 
            // textBoxStreet
            // 
            textBoxStreet.Location = new Point(156, 173);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(221, 31);
            textBoxStreet.TabIndex = 8;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(156, 210);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(221, 31);
            textBoxCity.TabIndex = 9;
            // 
            // textBoxPostal
            // 
            textBoxPostal.Location = new Point(156, 247);
            textBoxPostal.Name = "textBoxPostal";
            textBoxPostal.Size = new Size(221, 31);
            textBoxPostal.TabIndex = 10;
            // 
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelStreet.Location = new Point(91, 176);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(59, 25);
            labelStreet.TabIndex = 11;
            labelStreet.Text = "Ulica:";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCity.Location = new Point(75, 213);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(75, 25);
            labelCity.TabIndex = 12;
            labelCity.Text = "Miasto:";
            // 
            // labelPostal
            // 
            labelPostal.AutoSize = true;
            labelPostal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPostal.Location = new Point(12, 250);
            labelPostal.Name = "labelPostal";
            labelPostal.Size = new Size(138, 25);
            labelPostal.TabIndex = 13;
            labelPostal.Text = "Kod pocztowy:";
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.DropDownHeight = 100;
            comboBoxCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.IntegralHeight = false;
            comboBoxCountry.Items.AddRange(new object[] { "", "Polska", "Wielka Brytania", "Niemcy", "Francja", "Włochy", "USA", "Hiszpania", "Portugalia" });
            comboBoxCountry.Location = new Point(156, 284);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(221, 33);
            comboBoxCountry.TabIndex = 14;
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCountry.Location = new Point(99, 287);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(51, 25);
            labelCountry.TabIndex = 15;
            labelCountry.Text = "Kraj:";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(62, 336);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(112, 34);
            buttonOk.TabIndex = 16;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(213, 336);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(112, 34);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "Wyczyść";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 382);
            Controls.Add(buttonClear);
            Controls.Add(buttonOk);
            Controls.Add(labelCountry);
            Controls.Add(comboBoxCountry);
            Controls.Add(labelPostal);
            Controls.Add(labelCity);
            Controls.Add(labelStreet);
            Controls.Add(textBoxPostal);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxStreet);
            Controls.Add(textBoxNR);
            Controls.Add(textBoxName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelName);
            Controls.Add(labelNR);
            Controls.Add(labelFirstName);
            Controls.Add(rbFirm);
            Controls.Add(rbPerson);
            Name = "MainWindow";
            Text = "Mediator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelLastName;
        private RadioButton rbPerson;
        private RadioButton rbFirm;
        private Label labelFirstName;
        private Label labelNR;
        private Label labelName;
        private TextBox textBoxFirstName;
        private TextBox textBoxName;
        private TextBox textBoxNR;
        private TextBox textBoxStreet;
        private TextBox textBoxCity;
        private TextBox textBoxPostal;
        private Label labelStreet;
        private Label labelCity;
        private Label labelPostal;
        private ComboBox comboBoxCountry;
        private Label labelCountry;
        private Button buttonOk;
        private Button buttonClear;
    }
}