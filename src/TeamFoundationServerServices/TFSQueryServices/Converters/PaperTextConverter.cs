﻿// This source is subject to Microsoft Public License (Ms-PL).
// Please see http://taskcardcreator.codeplex.com for details.
// All other rights reserved.

using System;
using System.Windows;
using System.Windows.Data;

namespace TFSQueryServices.Converters
{
  public class PaperTextConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      var size = (Size)value;
      if (size != null)
      {
        return string.Format("{0}\" x {1}\"", size.Width, size.Height);
      }
      return "-";
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
