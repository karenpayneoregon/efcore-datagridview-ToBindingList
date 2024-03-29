﻿using System;
using System.ComponentModel;
using System.Diagnostics;
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
            var changes = DataOperations.ShowShortView();
            if (!string.IsNullOrWhiteSpace(changes))
            {
                Debug.WriteLine(changes);
            }
            Debug.WriteLine(DataOperations.Context.SaveChanges());
        }

        private void DebugViewButton_Click(object sender, EventArgs e)
        {
            if (LongViewCheckBox.Checked)
            {
                DebugViewForm form = new DebugViewForm("Long view", DataOperations.ShowLongView());
                form.ShowDialog();
            }
            else
            {
                var changes = DataOperations.ShowShortView();
                if (!string.IsNullOrWhiteSpace(changes))
                {
                    DebugViewForm form = new DebugViewForm("Short view", changes);
                    form.ShowDialog();
                }
            }

        }
        /// <summary>
        /// Example use extension method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentButton_Click(object sender, EventArgs e)
        {
            InformationDialog($"{_bindingSource.Fullname()}", "Current");
        }
    }
}
