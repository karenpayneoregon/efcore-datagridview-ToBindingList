using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

        public static string ShowShortView()
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

        public static string ShowLongView() => Context.ChangeTracker.DebugView.LongView;

        /// <summary>
        /// Get changes for any property changed as in
        /// this case changes are being tracked
        /// </summary>
        /// <returns>Changed properties for single Person</returns>
        /// <remarks>Generic names are used in the returning object</remarks>
        public static List<Tuple<string, object, object>> GetChanges()
        {
            var changes = new List<Tuple<string, object, object>>();

            var person = Context.Person.FirstOrDefault();

            person.FirstName += " Changes";


            var entry = Context.Entry(person);

            foreach (var property in entry.CurrentValues.Properties)
            {
                var propEntry = entry.Property(property.Name);

                if (propEntry.IsModified)
                {
                    changes.Add(new Tuple<string, object, object>(
                        property.Name,
                        propEntry.OriginalValue,
                        propEntry.CurrentValue));

                }
            }

            return changes;
        }
    }
}
