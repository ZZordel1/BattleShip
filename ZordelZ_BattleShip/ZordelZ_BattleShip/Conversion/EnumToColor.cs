using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ZordelZ_BattleShip.Conversion
{
    public class EnumToColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SolidColorBrush sC = null;

            int v = (int)value;
            if(v == 1)
            {
               sC = new SolidColorBrush(Color.FromRgb(91, 103, 255));
            }
            else if(v == 2)
            {
                sC = new SolidColorBrush(Color.FromRgb(154, 154, 154));
            }
            else if (v == 3)
            {
                sC = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }
            else if (v == 4)
            {
                sC = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            }
            return sC;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
