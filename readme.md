# WinForms DataGridView with EF Core 5

| Note  |
| :--- |
| The inital run of the application will not have any records, use the add button to add data. |

Typically when a developer new to working with database data in a Windows Form application tend to add rows rather than set the DataGridView DataSource property which means more code rather than setting the DataGridView DataSource property using a DataSet or DataTable.

When setting the DataSource property for a DataGridView to a DataTable or DataSet then perform save operations all works as expected. This is not the case when working with Entity Framework Core 5 (EF Core 5).

**Basic mistake** where adding a new record (as shown in `Form1`) will not display the new record in the DataGridView.

```csharp
private async void OnShown(object sender, EventArgs e)
{
    var list =  await DataOperations.People();
    dataGridView1.DataSource = list;
}
```

**Next level** is to use a BindingList&lt;T&gt;, in this case BindingList&lt;`Person`&gt;.

The key is [ToBindingList()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.observablecollectionextensions.tobindinglist?view=efcore-5.0) extension method.

```csharp
public static async Task<BindingList<Person>> PeopleLocal()
{
    return await Task.Run(async () =>
    {
        await Context.Person.LoadAsync();
        return  Context.Person.Local.ToBindingList();
    });
}
```

In Form2 data is load

```sharp
private async void OnShown(object sender, EventArgs e)
{
    BindingList<Person> peopleLocalList = await DataOperations.PeopleLocal();
    dataGridView1.DataSource = peopleLocalList;
}
```

Now when adding a new Person record the record is displayed in the DataGridView.

**Even better** is to incorporate a [BindingSource](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.bindingsource?view=net-5.0) which provides navigation ability, useful methods and events.

```csharp
private readonly BindingSource _bindingSource = new BindingSource();

private async void OnShown(object sender, EventArgs e)
{
    BindingList<Person> peopleLocalList = await DataOperations.PeopleLocal();
    _bindingSource.DataSource = peopleLocalList;

    dataGridView1.DataSource = _bindingSource;
}
```
</br>

### Evaluating the three approaches

- **Form1** just does not work
- **Form2** we need to *touch* the DataGridView once loaded to get at loaded data
- **Form3** Set the DataGridView.DataSource and no need to *touch* the DataGridView once loaded to access data.

# Evaluating local changes

In DataOperations class, Show method provides access to the [State](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.entitystate?view=efcore-5.0) of each record.

```csharp
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
```

</br>

# Lessons learned

What can be learned is not to work directly with a DataGridView for displaying database data using EF Core 5 or higher.

Novice developers tend to want the easiest way to code a solution which is great while when they don’t understand and/or think ahead will a) write a good deal more code then required b) seek help and in many cases unwilling to accept, in this case using a BindingList with a BindingSource.

So looking at the `big picture` past working with a DataGridView and EF Core is to think ahead for other coding task. Even better, take time when appropriate after reading documentation write unit test to validate that what you think the code should do actually does.

# Running code

- **Requires**
  - Visual Studio 2019 or higher
  - SQL-Server Express edition or higher
  - Run createPersonTable.sql script
  - In Program.cs, set the startup form to Form1, run, try Form2, run the Form3 and run


# See also

- Microsoft TechNet Wiki 
  - [Motivation for moving to Entity Framework Core (C#)](https://social.technet.microsoft.com/wiki/contents/articles/53996.motivation-for-moving-to-entity-framework-core-c.aspx)
  - [Entity Framework: Disconnected Entities](https://social.technet.microsoft.com/wiki/contents/articles/53180.entity-framework-disconnected-entities.aspx)
  - [Entity Framework Windows Form validation](https://social.technet.microsoft.com/wiki/contents/articles/53201.entity-framework-windows-form-validation.aspx)
  - [Entity Framework Core 3: projections](https://social.technet.microsoft.com/wiki/contents/articles/53881.entity-framework-core-3-projections.aspx) (valid with newer releases)



