using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace FrontendApplication
{
    public partial class Form4 : Form
    {
        private readonly BindingSource _bindingSource = new();
        private BindingList<Person> _peopleLocalList;
        public Form4()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            _peopleLocalList = new BindingList<Person>();

            _bindingSource.DataSource = _peopleLocalList;
            dataGridView1.DataSource = _bindingSource;
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is null) return;
            Person person = _peopleLocalList[_bindingSource.Position];
            MessageBox.Show($"{person.FirstName} {person.LastName}");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var test = _peopleLocalList.FirstOrDefault(p => p.Id == 3);
            if (test is null)
            {
                _peopleLocalList.Add(new Person()
                {
                    Id = 3, FirstName = "Karen", LastName = "Payne"
                });
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is null) return;
            Person person = _peopleLocalList[_bindingSource.Position];
            person.FirstName = "Anne";
            person.LastName = "Payne";
        }
    }
}
