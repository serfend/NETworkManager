﻿using System;
using System.Globalization;
using System.Windows.Data;
using NETworkManager.Models.Network;
using NETworkManager.Localization.Resources;

namespace NETworkManager.Converters
{
    public sealed class DNSServerInfoToString : IValueConverter
    {
        /* Convert an MahApps.Metro.Accent (from wpf/xaml-binding) to a Brush to fill rectangle with color in a ComboBox */
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not DNSServerInfo info)
                return "-/-";

            return info.UseWindowsDNSServer ? $"[{Strings.WindowsDNSSettings}]" : info.Name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
