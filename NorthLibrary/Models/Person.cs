using System.ComponentModel;
using System.Runtime.CompilerServices;

#nullable disable

namespace DataLibrary.Models
{
    public partial class Person : INotifyPropertyChanged
    {
        private string _firstName;
        public int Id { get; set; }

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}