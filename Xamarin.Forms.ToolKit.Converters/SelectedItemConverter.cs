/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using System;
using System.Globalization;

namespace Xamarin.Forms.ToolKit.Converters
{
    public class SelectedItemConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var eventArgs = value as ItemTappedEventArgs;
            if (eventArgs == null)
                return null;

            return eventArgs.Item;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
