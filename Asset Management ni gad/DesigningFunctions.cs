using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Management_ni_gad
{
    internal class DesigningFunctions
    {
        public static void CenterPanel(Panel child, Panel parent)
        {
            int x = (parent.Width - child.Width) / 2;
            int y = (parent.Height - child.Height) / 2;
            child.Location = new Point(x, y);
        }

    }

}
