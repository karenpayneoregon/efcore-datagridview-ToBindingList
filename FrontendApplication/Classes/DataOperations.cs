using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontendApplication.Classes
{
    public class DataOperations
    {
        public static BaseContext Context = new ();

        public static async Task<List<Person>> People()
        {
            return await Task.Run(async () => await Context.Person.ToListAsync());
        }
        public static async Task<BindingList<Person>> PeopleLocal()
        {
            return await Task.Run(async () =>
            {
                await Context.Person.LoadAsync();
                return  Context.Person.Local.ToBindingList();
            });
        }

        public static string Show()
        {
            StringBuilder builder = new ();
            foreach (var person in Context.Person.Local)
            {
                if (Context.Entry(person).State != EntityState.Unchanged)
                {
                    builder.AppendLine($"{person.Id} {person.FirstName} {person.LastName} {Context.Entry(person).State}");
                }
            }

            return builder.ToString();
        }
    }
}
