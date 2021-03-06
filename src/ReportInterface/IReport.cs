﻿// This source is subject to Microsoft Public License (Ms-PL).
// Please see http://taskcardcreator.codeplex.com for details.
// All other rights reserved.

using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows;
using System.Windows.Documents;

namespace ReportInterface
{
  public interface IReport
  {
    bool IsSupported(IEnumerable<string> wiTypeCollection);
    string Description { get; }
    Size PaperSize { get; }
    Margins Margins { get; }
    bool TeamCustomized { get; }
    FixedDocument Create(IEnumerable<ReportItem> data);
  }
}
