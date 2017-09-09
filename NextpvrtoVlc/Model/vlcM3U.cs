using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextpvrtoVlc.Model
{
    class vlcM3U
    {
        public static String  coverted (String _name, String _freq, String _programm)
        {
            StringBuilder vlc = new StringBuilder();
            vlc.Append("#EXTINF:0,").AppendLine(_name);
            vlc.Append("#EXTVLCOPT:program=").AppendLine(_programm);
            vlc.Append("dvb-t://frequency=").Append(_freq).AppendLine(":bandwidth=0");
            return vlc.ToString();
        }
    }
}
