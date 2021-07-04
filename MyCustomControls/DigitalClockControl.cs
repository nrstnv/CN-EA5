using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MyCustomControls
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:MyCustomControls"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:MyCustomControls;assembly=MyCustomControls"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    public class DigitalClockControl : Control
    {
        private readonly System.Timers.Timer timer = new();

        public DigitalClockControl()
        {
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed_EventHandler;

            timer.Start();
            this.DataContext = this;

        }

        private void Timer_Elapsed_EventHandler(object sender, System.Timers.ElapsedEventArgs e)
        {

            this.Dispatcher.Invoke(() =>
            {
                Time = DateTime.Now.ToLongTimeString();
            });

        }


        /// <summary>
        /// statischer Konstruktor
        /// </summary>
        static DigitalClockControl()
        {
            // Ohne diese Anweisung wird das benutzerdefinierte Steuerelement nicht angezeigt
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DigitalClockControl),
                new FrameworkPropertyMetadata(typeof(DigitalClockControl)));
        }


        /// <summary>
        /// Abhängigkeitseigenschaft
        /// </summary>
        public string Time
        {
            get { return (string)GetValue(TimeProperty); }
            set { SetValue(TimeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Time.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TimeProperty =
            DependencyProperty.Register("Time", typeof(string), typeof(DigitalClockControl), new PropertyMetadata("defaultValue"));

    }
}
