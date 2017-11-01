using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aerodrom
{
    class AH:airplane
    {
        public AH(string name_plane, int n_engine, int speed_max)
            : base(name_plane, n_engine, speed_max)
        {
            AutoPilotOn = false;
            Console.WriteLine("З Вами був український літак");
            Console.ReadKey();
        }
    }
}
