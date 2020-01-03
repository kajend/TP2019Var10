using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Services
{
    public class CheckerStatus
    {
        public static string CheckStatus(CheckedListBox checkedListBox)
        {
            StringBuilder status = new StringBuilder();
            foreach (var c in checkedListBox.CheckedItems)
            {
                status.Append(c);
                status.Append(" STATUS:");
                status.Append(
                    new OrderService().FindElementById(GetId((c as string)))
                    .Status);
            }
            return status.ToString();
        }

        private static string GetId(string nameOfOrder)
        {
            var wordsInName = nameOfOrder.Split();
            return wordsInName[0] + " " + wordsInName[1];
        }
    }
}
