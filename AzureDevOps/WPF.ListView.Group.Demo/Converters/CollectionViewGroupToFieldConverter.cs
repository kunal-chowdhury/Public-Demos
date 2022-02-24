using System;
using System.Globalization;
using System.Windows.Data;
using WPF.ListView.Group.Demo.Models;

namespace WPF.ListView.Group.Demo.Converters
{
    public class CollectionViewGroupToFieldConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var collectionViewGroup = value as CollectionViewGroup;
            var employee = collectionViewGroup.Items[0] as Employee;

            return employee.Role;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
