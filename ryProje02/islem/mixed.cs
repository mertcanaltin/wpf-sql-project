using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ryProje02.islem
{
    public class mixed
    {
        public static void sesCal(string yol)
        {
            MediaPlayer player = new MediaPlayer();
            player.Open(new Uri(yol, UriKind.Relative));
            player.Play();
        }
    }
}
