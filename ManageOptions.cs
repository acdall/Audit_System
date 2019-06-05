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
            }
            catch
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
            { //Changes been saved???
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
            try
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
                else if (instanceLabel.Text == "Manage Shifts")
                {
                    this.Hide(); //Hides Menu
                    manageShiftForm addShift = new manageShiftForm(); //Create instance ManageOptions
                    addShift.ShiftLabel = "Add a New Shift"; //Changes the label in the ManageOptions form
                    addShift.ShowDialog(); // Shows ManageOptions
                }
                else if (instanceLabel.Text == "Manage Zones")
                {
                    this.Hide(); //Hides Menu
                    ManageZone addZone = new ManageZone(); //Create instance ManageOptions
                    addZone.ZoneLabel = "Add a New Zone"; //Changes the label in the ManageOptions form
                    addZone.ShowDialog(); // Shows ManageOptions
                }
                else if (instanceLabel.Text == "Manage Products")
                {
                    this.Hide(); //Hides Menu
                    ManageProducts addProduct = new ManageProducts(); //Create instance ManageOptions
                    addProduct.ProductLabel = "Add a New Product"; //Changes the label in the ManageOptions form
                    addProduct.ShowDialog(); // Shows ManageOptions
                }
                else if (instanceLabel.Text == "Manage Models")
                {
                    this.Hide(); //Hides Menu
                    ManageModels addModel = new ManageModels(); //Create instance ManageOptions
                    addModel.ModelLabel = "Add a New Model"; //Changes the label in the ManageOptions form
                    addModel.ShowDialog(); // Shows ManageOptions
                }
                else if (instanceLabel.Text == "Manage Lines")
                {
                    this.Hide(); //Hides Menu
                    ManageLines addLine = new ManageLines(); //Create instance ManageOptions
                    addLine.LineLabel = "Add a New Line"; //Changes the label in the ManageOptions form
                    addLine.ShowDialog(); // Shows ManageOptions
                }
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);

            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to Permanently Delete this Item?", "Delete?", MessageBoxButtons.YesNo); //Warning 
                if (answer == DialogResult.Yes) //User answer selection 
                {
                    factorsListBox.Items.Remove(factorsListBox.SelectedItem);
                    factorsListBox.Refresh();
                }
                
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);

            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (instanceLabel.Text == "Manage Factories")
                {
                    this.Hide(); //Hides Menu
                    ManageFactories factoryEdit = new ManageFactories(); //Create instance ManageOptions
                    factoryEdit.FactoryLabel = "Edit a Factory"; //Changes the label in the ManageOptions form
                    factoryEdit.ShowDialog(); // Shows ManageOptions
                }
                else if (instanceLabel.Text == "Manage Categories")
                {
                    this.Hide(); //Hides Menu
                    ManageCategories editCategory = new ManageCategories(); //Create instance ManageOptions
                    editCategory.CategoryLabel = "Edit a Category"; //Changes the label in the ManageOptions form
                    editCategory.ShowDialog(); // Shows ManageOptions
                }
                else if (instanceLabel.Text == "Manage Defects")
                {
                    this.Hide(); //Hides Menu
                    ManageDefects editDefect = new ManageDefects(); //Create instance ManageOptions
                    editDefect.DefectLabel = "Edit a Defect"; //Changes the label in the ManageOptions form
                    editDefect.ShowDialog(); // Shows ManageOptions
                }
                else if (instanceLabel.Text == "Manage Shifts")
                {
                    this.Hide(); //Hides Menu
                    manageShiftForm editShift = new manageShiftForm(); //Create instance ManageOptions
                    editShift.ShiftLabel = "Edit a Shift"; //Changes the label in the ManageOptions form
                    editShift.ShowDialog(); // Shows ManageOptions
                }
                else if (instanceLabel.Text == "Manage Zones")
                {
                    this.Hide(); //Hides Menu
                    ManageZone editZone = new ManageZone(); //Create instance ManageOptions
                    editZone.ZoneLabel = "Edit a Zone"; //Changes the label in the ManageOptions form
                    editZone.ShowDialog(); // Shows ManageOptions
                }
                else if (instanceLabel.Text == "Manage Products")
                {
                    this.Hide(); //Hides Menu
                    ManageProducts editProduct = new ManageProducts(); //Create instance ManageOptions
                    editProduct.ProductLabel = "Edit a Product"; //Changes the label in the ManageOptions form
                    editProduct.ShowDialog(); // Shows ManageOptions
                }
                else if (instanceLabel.Text == "Manage Models")
                {
                    this.Hide(); //Hides Menu
                    ManageModels editModel = new ManageModels(); //Create instance ManageOptions
                    editModel.ModelLabel = "Edit a Model"; //Changes the label in the ManageOptions form
                    editModel.ShowDialog(); // Shows ManageOptions
                }
                else if (instanceLabel.Text == "Manage Lines")
                {
                    this.Hide(); //Hides Menu
                    ManageLines editLine = new ManageLines(); //Create instance ManageOptions
                    editLine.LineLabel = "Edit a Line"; //Changes the label in the ManageOptions form
                    editLine.ShowDialog(); // Shows ManageOptions
                }
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);

            }
        }

        private void FactorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load data from database..... maybe highlight saved? 
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            //autosearch data 
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
       
        }
    }
}
