using System.ComponentModel;
using System.Windows.Forms;
using DataLibrary.Models;

namespace FrontendApplication.Classes
{
    public static class Extensions
    {
        /// <summary>
        /// Add new person to <see cref="BindingList"/> of <see cref="Person"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="person"></param>
        public static void AddPersonFromBindingList(this DataGridView sender, Person person)
        {
            ((BindingList<Person>)sender.DataSource).Add(person);
        }
        public static void AddPersonFromBindingSource(this BindingSource sender, Person person)
        {
            ((BindingList<Person>)sender.DataSource).Add(person);
        }
    }
}
