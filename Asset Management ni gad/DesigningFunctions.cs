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
        public static void btnSelected(Button selectedBtn, params Button[] allButtons)
        {
            foreach (Button btn in allButtons)
                btn.Font = new Font(btn.Font.FontFamily, 10, btn.Font.Style & ~FontStyle.Underline); // Set font size to 10 (or any size you prefer)

            selectedBtn.Font = new Font(selectedBtn.Font.FontFamily, 12, selectedBtn.Font.Style | FontStyle.Underline); // Set a larger size for the selected button (e.g., 12)
        }


    }
}
