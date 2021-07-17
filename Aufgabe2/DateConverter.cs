using System;
using System.Globalization;
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
                string dateOfBirth = d.ToString("dd.MM.yyyy");
                return (dateOfBirth);
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
