using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Kant.Wpf.Toolkit
{
    public static class MeasureHepler
    {
        public static Size MeasureString(TextInformation information, CultureInfo culture)
        {
            var formattedText = new FormattedText(information.Text, culture, information.FlowDirection, information.Typeface, information.FontSize, information.Foreground);

            return new Size(formattedText.Width, formattedText.Height);
        }
    }
}
