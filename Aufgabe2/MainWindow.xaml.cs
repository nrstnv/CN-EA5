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

        /// <summary>
        /// Kontakte gruppieren.
        /// Bei der Auswahl der Checkbox wird zur 
        /// ICollectionView.GroupDescriptions-Eigenschaft der Ansicht ein geeignetes
        /// PropertyGroupDescription-Objekt hinzugefügt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortByGroup_IsChecked(object sender, RoutedEventArgs e)
        {
            _view.GroupDescriptions.Add(new PropertyGroupDescription(nameof(Person.Relation)));
        }

        /// <summary>
        /// Gruppierung aufheben.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortByGroup_IsUnchecked(object sender, RoutedEventArgs e)
        {
            _view.GroupDescriptions.Clear();
        }

        /// <summary>
        /// Kontakte nach Freunden filtern.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterFriends_IsChecked(object sender, RoutedEventArgs e)
        {
            _view.Filter = new Predicate<object>(delegate (object o)
            {
                Person person = o as Person;
                return person.Relation == Relationship.Friend;
            });
        }

        /// <summary>
        /// Filterung aufheben.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterFriends_IsUnchecked(object sender, RoutedEventArgs e)
        {
            _view.Filter = null;
        }
    }
}
