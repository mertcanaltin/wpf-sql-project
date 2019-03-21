using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ryProje02.islem
{
    public class formCagirma
    {
        public static void formYukleme(Grid formGrid, UserControl ucGetir)
        {
            if (formGrid.Children.Count>0)
            {
                formGrid.Children.Clear();
                formGrid.Children.Add(ucGetir);
            }
            else
            {
                formGrid.Children.Add(ucGetir);
            }
        }
    }
}
