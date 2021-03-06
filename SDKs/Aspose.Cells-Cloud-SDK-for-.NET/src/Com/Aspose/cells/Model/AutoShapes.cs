using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Cells.Model {
  public class AutoShapes {
    public List<LinkElement> AutoShapeList { get; set; }

    public Link link { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AutoShapes {\n");
      sb.Append("  AutoShapeList: ").Append(AutoShapeList).Append("\n");
      sb.Append("  link: ").Append(link).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
