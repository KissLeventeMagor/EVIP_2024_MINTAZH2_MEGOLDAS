using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace gyakharom
{
    public class DataModel : INotifyPropertyChanged
    {
        private ObservableCollection<Animal> _animals { get; set; }
        public ObservableCollection<Animal> Animals
        {
            get => _animals;
            set
            {
                if (_animals != value)
                {
                    _animals = value;
                    OnPropertyChanged();
                }
            }
        }
        
        private string _currentname;
        private string _currenttype;
        private string _currentage;

        public string CurrentName
        {
            get => _currentname;
            set
            {
                if (_currentname != value)
                {
                    _currentname = value;
                    OnPropertyChanged();
                    Command?.RaiseCanExecuteChanged();
                }
            }
        }

        public string CurrentType
        {
            get => _currenttype;
            set
            {
                if (_currenttype != value)
                {
                    _currenttype = value;
                    OnPropertyChanged();
                    Command?.RaiseCanExecuteChanged();
                }
            }
        }

        public string CurrentAge
        {
            get => _currentage;
            set
            {
                if (_currentage != value)
                {
                    _currentage = value;
                    OnPropertyChanged();
                    Command?.RaiseCanExecuteChanged();
                }
            }
        }
        public AddCommand Command { get; }
        public HowManyCommand HowManyCommand { get; }
        public string HowManyA { get; set; }
        public MainPage mainPage { get; set; }

        public DataModel(MainPage mainPage)
        {
            _animals = new ObservableCollection<Animal>();
            Command = new AddCommand(this);
            HowManyCommand = new HowManyCommand(this);
            FillAnimalCollection();
            this.mainPage = mainPage;
        }

        public void AddAnimalToCollection()
        {
            Animals.Add(new Animal(CurrentName, CurrentType, CurrentAge));
            CurrentName = String.Empty; CurrentType = String.Empty; CurrentAge = String.Empty;
        }

        private void FillAnimalCollection()
        {
            Animals.Add(new Animal("Rex", "kutya", "5"));
            Animals.Add(new Animal("Cirmi", "macska", "3"));
            Animals.Add(new Animal("Paco", "papagáj", "2"));
            Animals.Add(new Animal("Morzsi", "kutya", "7"));
            Animals.Add(new Animal("Alex", "macska", "4"));
            Animals.Add(new Animal("Alma", "kanári", "1"));
            Animals.Add(new Animal("Ambrus", "hörcsög", "2"));
            Animals.Add(new Animal("Bogyó", "teknős", "10"));
            Animals.Add(new Animal("Fifi", "nyúl", "3"));
            Animals.Add(new Animal("Liza", "ló", "12"));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
