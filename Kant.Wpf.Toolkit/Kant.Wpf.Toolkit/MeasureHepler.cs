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

        public static Size MeasureString(string text, Style style, CultureInfo culture)
        {
            if (style == null || style.Setters == null)
            {
                throw new ArgumentNullException("style or style.Setters is null");
            }

            var flowDirection = FlowDirection.LeftToRight;
            var fontFamily = new FontFamily("Segoe UI");
            var fontSize = 12.0;
            var fontStyle = FontStyles.Normal;
            var fontWeight = FontWeights.Regular;
            var fontStretch = FontStretches.Normal;
            Brush foregroud = new SolidColorBrush(Colors.Black);

            foreach (var s in style.Setters)
            {
                var setter = (Setter)s;

                switch (setter.Property.Name)
                {
                    case "FlowDirectoin":
                        flowDirection = (FlowDirection)setter.Value;

                        break;
                    case "FontFamily":
                        fontFamily = (FontFamily)setter.Value;

                        break;
                    case "FontSize":
                        fontSize = (double)setter.Value;

                        break;
                    case "FontStyle":
                        fontStyle = (FontStyle)setter.Value;

                        break;
                    case "FontWeight":
                        fontWeight = (FontWeight)setter.Value;

                        break;
                    case "FontStretch":
                        fontStretch = (FontStretch)setter.Value;

                        break;
                    case "Foreground":
                        foregroud = (Brush)setter.Value;

                        break;
                    default:
                        break;
                }
            }

            var formattedText = new FormattedText(text, culture, flowDirection, new Typeface(fontFamily, fontStyle, fontWeight, fontStretch), fontSize, foregroud);

            return new Size(formattedText.Width, formattedText.Height);
        }
    }
}
