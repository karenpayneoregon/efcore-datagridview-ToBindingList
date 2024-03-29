﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using DataLibrary.Models;
using FrontendApplication.Classes;
using static FrontendApplication.Classes.Dialogs;

namespace FrontendApplication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            dataGridView1.AutoGenerateColumns = false;
            Shown += OnShown;
        }
        private async void OnShown(object sender, EventArgs e)
        {
            BindingList<Person> peopleLocalList = await DataOperations.PeopleLocal();

            dataGridView1.DataSource = peopleLocalList;

            AddButton.Enabled = true;
            SaveButton.Enabled = true;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FirstNameTextBox.Text) && !string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                dataGridView1.AddPersonFromBindingList(new Person()
                {
                    FirstName = FirstNameTextBox.Text, 
                    LastName = LastNameTextBox.Text
                });
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
            
            InformationDialog($"Count: {DataOperations.Context.SaveChanges()}","Changes");
        }
    }
}
