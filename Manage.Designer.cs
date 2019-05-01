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
            this.ratingsButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.factoriesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoriesButton
            // 
            this.categoriesButton.Location = new System.Drawing.Point(129, 81);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Size = new System.Drawing.Size(75, 23);
            this.categoriesButton.TabIndex = 0;
            this.categoriesButton.Text = "Categories";
            this.categoriesButton.UseVisualStyleBackColor = true;
            this.categoriesButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // productsButton
            // 
            this.productsButton.Location = new System.Drawing.Point(129, 128);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(75, 23);
            this.productsButton.TabIndex = 1;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // modelsButton
            // 
            this.modelsButton.Location = new System.Drawing.Point(315, 81);
            this.modelsButton.Name = "modelsButton";
            this.modelsButton.Size = new System.Drawing.Size(75, 23);
            this.modelsButton.TabIndex = 2;
            this.modelsButton.Text = "Models";
            this.modelsButton.UseVisualStyleBackColor = true;
            this.modelsButton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // ratingsButton
            // 
            this.ratingsButton.Location = new System.Drawing.Point(345, 128);
            this.ratingsButton.Name = "ratingsButton";
            this.ratingsButton.Size = new System.Drawing.Size(75, 23);
            this.ratingsButton.TabIndex = 3;
            this.ratingsButton.Text = "Ratings";
            this.ratingsButton.UseVisualStyleBackColor = true;
            this.ratingsButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(53, 257);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(99, 23);
            this.menuButton.TabIndex = 4;
            this.menuButton.Text = "Return to Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.Button5_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(191, 257);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.Button6_Click);
            // 
            // factoriesButton
            // 
            this.factoriesButton.Location = new System.Drawing.Point(255, 183);
            this.factoriesButton.Name = "factoriesButton";
            this.factoriesButton.Size = new System.Drawing.Size(75, 23);
            this.factoriesButton.TabIndex = 6;
            this.factoriesButton.Text = "Factories";
            this.factoriesButton.UseVisualStyleBackColor = true;
            this.factoriesButton.Click += new System.EventHandler(this.FactoriesButton_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.factoriesButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.ratingsButton);
            this.Controls.Add(this.modelsButton);
            this.Controls.Add(this.productsButton);
            this.Controls.Add(this.categoriesButton);
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.Manage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button categoriesButton;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button modelsButton;
        private System.Windows.Forms.Button ratingsButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button factoriesButton;
    }
}