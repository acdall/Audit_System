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
   

    public partial class ManageOptions : Form
    {

        public ManageOptions()
        {
            //get data from database and display on list 
            InitializeComponent();
        }
        
        public string Name
        {
            set { instanceLabel.Text = value; }
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if --changes are made, save button needs to be clicked!!
                this.Hide();
                MainMenu goBack = new MainMenu();
                goBack.ShowDialog();

            }catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK); 
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if -- changes are made, save button needs to be clicked!!

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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Save changed data to database
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);

            }
        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Manage getBack = new Manage();
                getBack.ShowDialog();
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);

            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (instanceLabel.Text == "Manage Factories")
            {
                this.Hide(); //Hides Menu
                ManageFactories factoryAdd = new ManageFactories(); //Create instance ManageOptions
                factoryAdd.FactoryLabel = "Add a New Factory"; //Changes the label in the ManageOptions form
                factoryAdd.ShowDialog(); // Shows ManageOptions
            }
            else if (instanceLabel.Text == "Manage Categories")
            {
                this.Hide(); //Hides Menu
                ManageCategories addCategory = new ManageCategories(); //Create instance ManageOptions
                addCategory.CategoryLabel = "Add a New Category"; //Changes the label in the ManageOptions form
                addCategory.ShowDialog(); // Shows ManageOptions
            }
            else if (instanceLabel.Text == "Manage Defects")
            {
                this.Hide(); //Hides Menu
                ManageDefects addDefect = new ManageDefects(); //Create instance ManageOptions
                addDefect.DefectLabel = "Add a New Defect"; //Changes the label in the ManageOptions form
                addDefect.ShowDialog(); // Shows ManageOptions
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //remove item from list in database
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //redirect to new form to edit an existing entry in the database
        }

        private void FactorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load data from database..... maybe highlight saved? 
        }
    }
}
