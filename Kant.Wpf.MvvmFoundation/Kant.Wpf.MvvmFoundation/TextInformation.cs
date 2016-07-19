using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Kant.Wpf.Toolkit
{
    public class TextInformation
    {
        public TextInformation()
        {
        }

        public string Text { get; set; }

        public FlowDirection FlowDirection { get; set; }

        public Typeface Typeface { get; set; }

        public double FontSize { get; set; }

        public Brush Foreground { get; set; }
    }
}
