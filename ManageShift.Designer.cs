namespace Audit_System
{
    partial class manageShiftForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.startTimelabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(242, 263);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(138, 263);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(28, 263);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // startComboBox
            // 
            this.startComboBox.FormattingEnabled = true;
            this.startComboBox.Items.AddRange(new object[] {
            "0:00",
            "0:30",
            "1:00",
            "1:30",
            "2:00",
            "2:30",
            "3:00",
            "3:30",
            "4:00",
            "4:30",
            "5:00",
            "5:30",
            "6:00",
            "6:30",
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.startComboBox.Location = new System.Drawing.Point(108, 181);
            this.startComboBox.Name = "startComboBox";
            this.startComboBox.Size = new System.Drawing.Size(193, 21);
            this.startComboBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(108, 143);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(193, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // shiftLabel
            // 
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Location = new System.Drawing.Point(40, 146);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(62, 13);
            this.shiftLabel.TabIndex = 6;
            this.shiftLabel.Text = "Shift Name:";
            // 
            // startTimelabel
            // 
            this.startTimelabel.AutoSize = true;
            this.startTimelabel.Location = new System.Drawing.Point(45, 189);
            this.startTimelabel.Name = "startTimelabel";
            this.startTimelabel.Size = new System.Drawing.Size(58, 13);
            this.startTimelabel.TabIndex = 7;
            this.startTimelabel.Text = "Start Time:";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(45, 230);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(55, 13);
            this.endTimeLabel.TabIndex = 8;
            this.endTimeLabel.Text = "End Time:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(119, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(98, 24);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "New Shift";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(108, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(193, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Factory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Line:";
            // 
            // endComboBox
            // 
            this.endComboBox.FormattingEnabled = true;
            this.endComboBox.Items.AddRange(new object[] {
            "0:00",
            "0:30",
            "1:00",
            "1:30",
            "2:00",
            "2:30",
            "3:00",
            "3:30",
            "4:00",
            "4:30",
            "5:00",
            "5:30",
            "6:00",
            "6:30",
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.endComboBox.Location = new System.Drawing.Point(108, 222);
            this.endComboBox.Name = "endComboBox";
            this.endComboBox.Size = new System.Drawing.Size(193, 21);
            this.endComboBox.TabIndex = 15;
            // 
            // manageShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 306);
            this.Controls.Add(this.endComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimelabel);
            this.Controls.Add(this.shiftLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.startComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Name = "manageShiftForm";
            this.Text = "Manage Shifts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox startComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.Label startTimelabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox endComboBox;
    }
}