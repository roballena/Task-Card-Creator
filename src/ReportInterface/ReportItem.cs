﻿// This source is subject to Microsoft Public License (Ms-PL).
// Please see http://taskcardcreator.codeplex.com for details.
// All other rights reserved.

using System.Collections.Generic;

namespace ReportInterface
{
  public class ReportItem
  {
    public ReportItem()
    {
      Fields = new Dictionary<string, object>();
    }
    public string Id { get; set; }
    public string ParentId { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
    public string State { get; set; }
    public string Description { get; set; }
    public Dictionary<string, object> Fields { get; set; } 
  }
}