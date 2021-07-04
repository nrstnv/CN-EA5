using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel;
=======
>>>>>>> f8ecc5fbe5f153ee414225b7bdd69e67bcc61b7d
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
<<<<<<< HEAD
        private Contacts _contacts;
        private ICollectionView _view;

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

=======
        public MainWindow()
        {
            InitializeComponent();
        }
>>>>>>> f8ecc5fbe5f153ee414225b7bdd69e67bcc61b7d
    }
}
