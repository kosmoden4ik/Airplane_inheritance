using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aerodrom
{
   public class Boing : airplane
    {

        public Boing(string name_plane, int n_engine, int speed_max):base(name_plane, n_engine, speed_max)
        {
            AutoPilotOn = false;
            Console.WriteLine("С вами был BOING");
            Console.ReadKey();
        }
        public override void Climb()
        {
            if (forsage == true) max_increment *= 3;
            if (forsage == false) increment = 1;
            if (!AutoPilotOn)  Altitude += increment;

            else if (Altitude + increment < MaxAltitudeAuto)
            {
                Altitude += increment;
            }
             else Altitude = MaxAltitudeAuto;
        }
    }
}
