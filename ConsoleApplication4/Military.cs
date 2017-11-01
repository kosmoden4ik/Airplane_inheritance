using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aerodrom
{
    public class Military:airplane
    {
        protected int n_missiles; // количество ракет
        protected bool fighter_aircraft; //самолет истребитель
        protected bool bomber_plane;
        //private string p1;
      //  private int p2;
       // private int p3;
       public Military(string name_plane, int n_engine, int speed_max):base(name_plane, n_engine, speed_max)
        {
           this.name_plane = name_plane;
           this.n_engine = n_engine;
           this.speed_max = speed_max;
           Console.WriteLine("Введите кол-во ракет:");
           bool alting = true;
           while (alting)
           {
               n_missiles = Convert.ToInt32(Console.ReadLine());
               if (n_missiles == 0)
               {
                   bomber_plane = true;
                   fighter_aircraft = false;
                   Console.WriteLine("С Вами был Самолёт бомбардировщик");
                   alting = false;
                   Console.ReadKey();
               }
               else if (n_missiles > 0 && n_missiles<10)
               {
                   bomber_plane = false;
                   fighter_aircraft = true;
                   Console.WriteLine("С Вами был Самолёт истребитель");
                   alting = false;
                   Console.ReadKey();
               }
           }
          
        }


    }
}