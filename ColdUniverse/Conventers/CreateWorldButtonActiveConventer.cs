using System;
using System.Globalization;
using System.Windows.Data;

namespace ColdUniverse.Conventers
{
    public class CreateWorldButtonActiveConventer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is String str && value != null)
            {
                // если названия нет, кнопка 'создать мир' не активна
                if (str != "")
                    return true;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
