using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary.Models;
using FrontendApplication.Classes;
using static FrontendApplication.Classes.Dialogs;

namespace FrontendApplication
{
    public partial class Form3 : Form
    {
        private readonly BindingSource _bindingSource = new();
        public Form3()
        {
            InitializeComponent();
            
            dataGridView1.AutoGenerateColumns = false;
            Shown += OnShown;
        }

        /// <summary>
        /// Initial run will have zero records
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnShown(object sender, EventArgs e)
        {
            BindingList<Person> peopleLocalList = await DataOperations.PeopleLocal();
            _bindingSource.DataSource = peopleLocalList;

            dataGridView1.DataSource = _bindingSource;

            AddButton.Enabled = true;
            SaveButton.Enabled = true;
            DebugViewButton.Enabled = true;
            CurrentButton.Enabled = true;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FirstNameTextBox.Text) && !string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                _bindingSource.AddPersonFromBindingSource(new Person()
                {
                    FirstName = FirstNameTextBox.Text, 
                    LastName = LastNameTextBox.Text
                });
                
                _bindingSource.MoveLast();
            }
            else
            {
                ErrorDialog("Requires first and last name!");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var changes = DataOperations.Show();
            if (!string.IsNullOrWhiteSpace(changes))
            {
                Debug.WriteLine(changes);
            }
            Debug.WriteLine(DataOperations.Context.SaveChanges());
        }

        private void DebugViewButton_Click(object sender, EventArgs e)
        {
            var changes = DataOperations.Show();
            if (!string.IsNullOrWhiteSpace(changes))
            {
                Debug.WriteLine(changes);
            }
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            InformationDialog($"{_bindingSource.Fullname()}", "Current");
        }
    }
}
