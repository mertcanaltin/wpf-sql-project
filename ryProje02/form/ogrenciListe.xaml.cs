using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ryProje02.form
{
    /// <summary>
    /// Interaction logic for ogrenciListe.xaml
    /// </summary>
    public partial class ogrenciListe : UserControl
    {
        public ogrenciListe()
        {
            InitializeComponent();
        }

        

        private void ogrenciListe_Loaded(object sender, RoutedEventArgs e)
        {
            vtIslem.veriDoldur(dgListe);
        }
    }
}
