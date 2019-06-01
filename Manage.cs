using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Audit_System
{
    public partial class Manage : Form
    {
        public Manage()
        {
            
            InitializeComponent();
        }

        private void FactoriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); //Hides Menu
                ManageOptions factoryOption = new ManageOptions(); //Create instance ManageOptions
                factoryOption.Name = "Manage Factories"; //Changes the label in the ManageOptions form
                factoryOption.ShowDialog(); // Shows ManageOptions
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);
            }
        }

        private void Manage_Load(object sender, EventArgs e)
        {

        }

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); //Hides Menu
                ManageOptions categoriesOption = new ManageOptions(); //Create instance ManageOptions
                categoriesOption.Name = "Manage Categories"; //Changes the label in the ManageOptions form
                categoriesOption.ShowDialog(); // Shows ManageOptions
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);
            }
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); //Hides Menu
                ManageOptions productsOption = new ManageOptions(); //Create instance ManageOptions
                productsOption.Name = "Manage Products"; //Changes the label in the ManageOptions form
                productsOption.ShowDialog(); // Shows ManageOptions
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);
            }
        }
        private void ZoneButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); //Hides Menu
                ManageOptions zoneOption = new ManageOptions(); //Create instance ManageOptions
                zoneOption.Name = "Manage Zones"; //Changes the label in the ManageOptions form
                zoneOption.ShowDialog(); // Shows ManageOptions
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);
            }
            }

        private void ShiftButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); //Hides Menu
                ManageOptions shiftsOption = new ManageOptions(); //Create instance ManageOptions
                shiftsOption.Name = "Manage Shifts"; //Changes the label in the ManageOptions form
                shiftsOption.ShowDialog(); // Shows ManageOptions
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);
            }
        }


        private void ModelsButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); //Hides Menu
                ManageOptions modelsOption = new ManageOptions(); //Create instance ManageOptions
                modelsOption.Name = "Manage Models"; //Changes the label in the ManageOptions form
                modelsOption.ShowDialog(); // Shows ManageOptions
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);
            }
        }

        private void LinesButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); //Hides Menu
                ManageOptions linesOption = new ManageOptions(); //Create instance ManageOptions
                linesOption.Name = "Manage Lines"; //Changes the label in the ManageOptions form
                linesOption.ShowDialog(); // Shows ManageOptions
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);
            }
        }

        private void ProductionButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); //Hides Menu
                ManageOptions productionOption = new ManageOptions(); //Create instance ManageOptions
                productionOption.Name = "Manage Productions"; //Changes the label in the ManageOptions form
                productionOption.ShowDialog(); // Shows ManageOptions
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);
            }
        }

        private void DefectButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); //Hides Menu
                ManageOptions defectOption = new ManageOptions(); //Create instance ManageOptions
                defectOption.Name = "Manage Defects"; //Changes the label in the ManageOptions form
                defectOption.ShowDialog(); // Shows ManageOptions
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo); //Warning 
                if (answer == DialogResult.Yes) //User answer selection 
                {
                    Application.Exit(); //Terminate because user selected yes
                }
            }catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                MainMenu goBack = new MainMenu(); // New instance for main menu
                goBack.ShowDialog();
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
