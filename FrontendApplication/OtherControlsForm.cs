using System;
using System.Windows.Forms;
using DataLibrary.Models;
using FrontendApplication.Classes;

namespace FrontendApplication
{
    public partial class OtherControlsForm : Form
    {
        private readonly BindingSource _bindingSource = new();
        public OtherControlsForm()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }

        private async void OnShown(object? sender, EventArgs e)
        {
            _bindingSource.DataSource = await DataOperations.PeopleLocal();

            listBox1.DisplayMember = "FullName";
            listBox1.DataSource = _bindingSource;
        }

        private void UpdateFirstNameButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                ((Person)_bindingSource.Current).FirstName = FirstNameTextBox.Text;
            }
            else
            {
                MessageBox.Show("Requires a first name");
            }
        }
    }
}
