using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataLibrary.Models;
using FrontendApplication.Classes;

namespace FrontendApplication
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            Shown += OnShown;
        }

        private async void OnShown(object sender, EventArgs e)
        {
            var list =  await DataOperations.People();

            dataGridView1.DataSource = list;

            AddButton.Enabled = true;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FirstNameTextBox.Text) && !string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                var person = new Person() {FirstName = FirstNameTextBox.Text, LastName = LastNameTextBox.Text};
                ((List<Person>) dataGridView1.DataSource).Add(person);
                
                var list = ((List<Person>)dataGridView1.DataSource);

                MessageBox.Show($"List count: {list.Count}\nDataGridView row count: {dataGridView1.Rows.Count}");
            }
            else
            {
                MessageBox.Show("Must enter first and last name");
            }
        }

    }
}
