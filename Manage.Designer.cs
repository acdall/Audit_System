namespace Audit_System
{
    partial class Manage
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
            this.categoriesButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.modelsButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.factoriesButton = new System.Windows.Forms.Button();
            this.defectButton = new System.Windows.Forms.Button();
            this.linesButton = new System.Windows.Forms.Button();
            this.shiftButton = new System.Windows.Forms.Button();
            this.zoneButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // categoriesButton
            // 
            this.categoriesButton.Location = new System.Drawing.Point(93, 94);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Size = new System.Drawing.Size(75, 23);
            this.categoriesButton.TabIndex = 0;
            this.categoriesButton.Text = "Categories";
            this.categoriesButton.UseVisualStyleBackColor = true;
            this.categoriesButton.Click += new System.EventHandler(this.CategoriesButton_Click);
            // 
            // productsButton
            // 
            this.productsButton.Location = new System.Drawing.Point(93, 140);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(75, 23);
            this.productsButton.TabIndex = 1;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // modelsButton
            // 
            this.modelsButton.Location = new System.Drawing.Point(238, 140);
            this.modelsButton.Name = "modelsButton";
            this.modelsButton.Size = new System.Drawing.Size(75, 23);
            this.modelsButton.TabIndex = 2;
            this.modelsButton.Text = "Models";
            this.modelsButton.UseVisualStyleBackColor = true;
            this.modelsButton.Click += new System.EventHandler(this.ModelsButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(84, 293);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(99, 23);
            this.menuButton.TabIndex = 4;
            this.menuButton.Text = "Return to Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(238, 293);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // factoriesButton
            // 
            this.factoriesButton.Location = new System.Drawing.Point(238, 94);
            this.factoriesButton.Name = "factoriesButton";
            this.factoriesButton.Size = new System.Drawing.Size(75, 23);
            this.factoriesButton.TabIndex = 6;
            this.factoriesButton.Text = "Factories";
            this.factoriesButton.UseVisualStyleBackColor = true;
            this.factoriesButton.Click += new System.EventHandler(this.FactoriesButton_Click);
            // 
            // defectButton
            // 
            this.defectButton.Location = new System.Drawing.Point(238, 226);
            this.defectButton.Name = "defectButton";
            this.defectButton.Size = new System.Drawing.Size(75, 23);
            this.defectButton.TabIndex = 7;
            this.defectButton.Text = "Defect";
            this.defectButton.UseVisualStyleBackColor = true;
            this.defectButton.Click += new System.EventHandler(this.DefectButton_Click);
            // 
            // linesButton
            // 
            this.linesButton.Location = new System.Drawing.Point(238, 187);
            this.linesButton.Name = "linesButton";
            this.linesButton.Size = new System.Drawing.Size(75, 23);
            this.linesButton.TabIndex = 8;
            this.linesButton.Text = "Lines";
            this.linesButton.UseVisualStyleBackColor = true;
            this.linesButton.Click += new System.EventHandler(this.LinesButton_Click);
            // 
            // shiftButton
            // 
            this.shiftButton.Location = new System.Drawing.Point(93, 226);
            this.shiftButton.Name = "shiftButton";
            this.shiftButton.Size = new System.Drawing.Size(75, 23);
            this.shiftButton.TabIndex = 10;
            this.shiftButton.Text = "Shift";
            this.shiftButton.UseVisualStyleBackColor = true;
            this.shiftButton.Click += new System.EventHandler(this.ShiftButton_Click);
            // 
            // zoneButton
            // 
            this.zoneButton.Location = new System.Drawing.Point(93, 187);
            this.zoneButton.Name = "zoneButton";
            this.zoneButton.Size = new System.Drawing.Size(75, 23);
            this.zoneButton.TabIndex = 11;
            this.zoneButton.Text = "Zone";
            this.zoneButton.UseVisualStyleBackColor = true;
            this.zoneButton.Click += new System.EventHandler(this.ZoneButton_Click_1);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(117, 16);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(144, 24);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Manage Menu";
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 373);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.zoneButton);
            this.Controls.Add(this.shiftButton);
            this.Controls.Add(this.linesButton);
            this.Controls.Add(this.defectButton);
            this.Controls.Add(this.factoriesButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.modelsButton);
            this.Controls.Add(this.productsButton);
            this.Controls.Add(this.categoriesButton);
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.Manage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button categoriesButton;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button modelsButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button factoriesButton;
        private System.Windows.Forms.Button defectButton;
        private System.Windows.Forms.Button linesButton;
        private System.Windows.Forms.Button shiftButton;
        private System.Windows.Forms.Button zoneButton;
        private System.Windows.Forms.Label titleLabel;
    }
}