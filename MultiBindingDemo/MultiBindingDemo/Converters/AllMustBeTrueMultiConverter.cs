using System;
using System.Globalization;
using Xamarin.Forms;

namespace MultiBindingDemo.Converters
{
    public class AllMustBeTrueMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            bool result = true;

            foreach (object value in values)
            {
                if (value is bool)
                {
                    result = result && (bool)value;
                }
                else
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
