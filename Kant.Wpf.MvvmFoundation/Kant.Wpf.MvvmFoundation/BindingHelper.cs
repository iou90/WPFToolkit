using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Kant.Wpf.MvvmFoundation
{
    public static class BindingHelper
    {
        public static Binding ConfigureBinding(string path, object source, BindingMode mode, IValueConverter converter, UpdateSourceTrigger trigger)
        {
            var binding = ConfigureBinding(path, source, mode, converter);
            binding.UpdateSourceTrigger = trigger;

            return binding;
        }

        public static Binding ConfigureBinding(string path, RelativeSource relativeSouce, BindingMode mode, IValueConverter converter, UpdateSourceTrigger trigger)
        {
            var binding = ConfigureBinding(path, relativeSouce, mode, converter);
            binding.UpdateSourceTrigger = trigger;

            return binding;
        }

        public static Binding ConfigureBinding(string path, object source, BindingMode mode, IValueConverter converter)
        {
            var binding = ConfigureBinding(path, source, mode);
            binding.Converter = converter;

            return binding;
        }

        public static Binding ConfigureBinding(string path, RelativeSource relativeSouce, BindingMode mode, IValueConverter converter)
        {
            var binding = ConfigureBinding(path, relativeSouce, mode);
            binding.Converter = converter;

            return binding;
        }

        public static Binding ConfigureBinding(string path, RelativeSource relativeSouce, BindingMode mode, UpdateSourceTrigger trigger)
        {
            var binding = ConfigureBinding(path, relativeSouce, mode);
            binding.UpdateSourceTrigger = trigger;

            return binding;
        }

        public static Binding ConfigureBinding(string path, object source, BindingMode mode, UpdateSourceTrigger trigger)
        {
            var binding = ConfigureBinding(path, source, mode);
            binding.UpdateSourceTrigger = trigger;

            return binding;
        }

        public static Binding ConfigureBinding(string path, RelativeSource relativeSouce, IValueConverter converter)
        {
            var binding = ConfigureBinding(path, relativeSouce);
            binding.Converter = converter;

            return binding;
        }

        public static Binding ConfigureBinding(string path, object source, IValueConverter converter)
        {
            var binding = ConfigureBinding(path, source);
            binding.Converter = converter;

            return binding;
        }

        public static Binding ConfigureBinding(string path, object source, UpdateSourceTrigger trigger)
        {
            var binding = ConfigureBinding(path, source);
            binding.UpdateSourceTrigger = trigger;

            return binding;
        }

        public static Binding ConfigureBinding(string path, RelativeSource relativeSouce, UpdateSourceTrigger trigger)
        {
            var binding = ConfigureBinding(path, relativeSouce);
            binding.UpdateSourceTrigger = trigger;

            return binding;
        }

        public static Binding ConfigureBinding(string path, object source, BindingMode mode)
        {
            var binding = ConfigureBinding(path, source);
            binding.Mode = mode;

            return binding;
        }

        public static Binding ConfigureBinding(string path, RelativeSource relativeSouce, BindingMode mode)
        {
            var binding = ConfigureBinding(path, relativeSouce);
            binding.Mode = mode;

            return binding;
        }

        public static Binding ConfigureBinding(string path, object source)
        {
            var binding = new Binding(path);
            binding.Source = source;

            return binding;
        }

        public static Binding ConfigureBinding(string path, RelativeSource relativeSource)
        {
            var binding = new Binding(path);
            binding.RelativeSource = relativeSource;

            return binding;
        }
    }
}
