using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Discord.Example.Planets.WPF.Converters;
public class ColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is Models.Color color)
        {
            return new SolidColorBrush(Color.FromArgb((byte)color.A, (byte)color.R, (byte)color.G, (byte)color.B));
        }

        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
