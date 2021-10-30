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

namespace FrontendApplication
{
    public partial class Form3 : Form
    {
        private readonly BindingSource _bindingSource = new ();
        private BindingList<Person> _peopleLocalList;
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
            _peopleLocalList = await DataOperations.PeopleLocal();

            _bindingSource.DataSource = _peopleLocalList;

            dataGridView1.DataSource = _bindingSource;

            AddButton.Enabled = true;
            SaveButton.Enabled = true;
            CurrentButton.Enabled = true;
            DebugViewButton.Enabled = true;

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

        /// <summary>
        ///
        /// For an understanding see the following doc pages.
        /// 
        /// https://docs.microsoft.com/en-us/ef/core/change-tracking/change-detection#when-change-detection-is-needed
        /// https://docs.microsoft.com/en-us/ef/core/change-tracking/change-detection#methods-that-automatically-detect-changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DebugViewButton_Click(object sender, EventArgs e)
        {
            
            if (ViewCheckBox.Checked)
            {
                var f = new DebugViewForm("Long", DataOperations.Context.ChangeTracker.DebugView.LongView);
                f.ShowDialog();
            }
            else
            {
                var f = new DebugViewForm("Short", DataOperations.Context.ChangeTracker.DebugView.ShortView);
                f.ShowDialog();
            }
            
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is not null)
            {
                var person = _peopleLocalList[_bindingSource.Position];
                MessageBox.Show($@"{person.FirstName}");
            }
            
        }
    }
}
