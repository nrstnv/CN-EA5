using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aufgabe2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly Contacts _contacts;
        private readonly ICollectionView _view;

        public MainWindow()
        {
            InitializeComponent();
            _contacts = new Contacts();
            _view = CollectionViewSource.GetDefaultView(_contacts);
            _view.MoveCurrentToFirst();
            this.DataContext = this;
        }

        public ICollectionView Contacts
        {
            get { return _view; }
        }


        private void SortByGroup_IsChecked(object sender, RoutedEventArgs e)
        {
            _view.GroupDescriptions.Add(new PropertyGroupDescription(nameof(Person.Relation)));
        }

        private void SortByGroup_IsUnchecked(object sender, RoutedEventArgs e)
        {
            _view.GroupDescriptions.Clear();
        }


        private void FilterFriends_IsChecked(object sender, RoutedEventArgs e)
        {
            _view.Filter = new Predicate<object>(delegate (object o)
            {
                Person person = o as Person;
                return person.Relation == Relationship.Friend;
            });
        }

        private void FilterFriends_IsUnchecked(object sender, RoutedEventArgs e)
        {
            _view.Filter = null;
        }
    }
}
