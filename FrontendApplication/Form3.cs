﻿using System;
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
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form3()
        {
            InitializeComponent();
            
            dataGridView1.AutoGenerateColumns = false;
            Shown += OnShown;
        }

        private async void OnShown(object sender, EventArgs e)
        {
            BindingList<Person> peopleLocalList = await DataOperations.PeopleLocal();
            _bindingSource.DataSource = peopleLocalList;

            dataGridView1.DataSource = _bindingSource;

            AddButton.Enabled = true;
            SaveButton.Enabled = true;

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
    }
}