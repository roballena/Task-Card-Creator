﻿// This source is subject to Microsoft Public License (Ms-PL).
// Please see http://taskcardcreator.codeplex.com for details.
// All other rights reserved.

using ReportInterface;

namespace ScrumIndexCard3x5
{
  public class NonProductBacklogItemCardRow
  {
    public ReportItem WorkItem { get; private set; }

    public NonProductBacklogItemCardRow(ReportItem workItem)
    {
      WorkItem = workItem;
    }
  }
}