using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Aufgabe2
{
    class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                DateTime d = (DateTime)value;
                return d.ToString("dd.MM.yyyy");
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string dateString = value as string;
            if (string.IsNullOrEmpty(dateString))
                return DependencyProperty.UnsetValue;
            if (DateTime.TryParse(dateString, out DateTime date))
                return date;
            else
                return DependencyProperty.UnsetValue;
        }
    }
}
