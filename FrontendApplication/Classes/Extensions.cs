using System.ComponentModel;
using System.Windows.Forms;
using DataLibrary.Models;



namespace FrontendApplication.Classes
{
    public static class Extensions
    {
        /// <summary>
        /// Add new person to <seealso cref="BindingList&lt;T&gt;"/> of <see cref="Person"/>
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

        public static Person Person(this BindingSource sender) => (Person)sender.Current;
        public static string Fullname(this BindingSource sender) => ((Person)sender.Current).FullName;
    }
}
