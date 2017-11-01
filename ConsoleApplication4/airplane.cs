using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aerodrom
{
  public abstract  class  airplane
    {
      public int Altitude;
      protected string name_plane;
      protected int n_engine;//Количкство двигателей
      protected int speed_max;// Максимальная скорость 
      protected int Capacity { get;  set; }//вместимость
      protected bool AutoPilotOn { get; set; }
      protected bool forsage { get; set; }
      protected int increment;
      public int max_increment;
      public static int MinAltitudeAuto { get; set; }
      public static int MaxAltitudeAuto { get; set; }
      public void make_airoplane()
        {
           // int menu;
  
          //  menu=(int)Console.ReadLine();
            ///////////////////////////////////////////////////////////
                    string menu;
            bool Q = false;
            while (Q != true)
            {
                Console.WriteLine("Введите команду:\n A= - Ввод высоты\n Auto=1 - автопилот активирован");
                Console.WriteLine("F=1 форсаж активирован\n");
                Console.WriteLine("Q - для выхода из полётного меню\n");
                menu=Console.ReadLine();
                if (string.Compare(menu, "Q") == 0) return;
                if (string.Compare(menu, "q") == 0) return;
                string[] menu_x = menu.Split('=');
                switch (menu_x[0])
                {
                    case "A":
                        int Alt = Convert.ToInt32(menu_x[1]);
                        set_Altitude(Alt);
                        Console.WriteLine("Набрана высота - {0}", Altitude);
                        break;
                    case "Print":
                        Console.WriteLine("Текущая высота - {0}", Altitude);
                        break;
                    case "F":
                        Alt = Convert.ToInt32(menu_x[1]);
                        if (Alt == 1)
                        {
                            forsage = true;
                          Console.WriteLine("Форсаж включен");
                        }
                        else if (Alt == 0)
                        {
                            forsage = false;
                            Console.WriteLine("Форсаж выключен");
                        }
                        else Console.WriteLine("Error");
                        
                        break;
                    case "Auto":
                        Alt = Convert.ToInt32(menu_x[1]);
                        if (Alt == 1)
                        {
                            AutoPilotOn = true;
                            Console.WriteLine("Автопилот включен");
                        }
                        else if (Alt == 0)
                        {
                            AutoPilotOn = false;
                            Console.WriteLine("Автопилот выключен");
                        }
                        else Console.WriteLine("Error");

                        break;
                }
            }
        }

      protected airplane(string name_plane, int n_engine, int speed_max)
      {
          this.name_plane = name_plane;
          this.n_engine = n_engine;
          this.speed_max = speed_max;
          Altitude = 0;
          forsage = false;
          MaxAltitudeAuto=3000;
          MinAltitudeAuto = 500;
          max_increment = 2;
          ///////////////////////////////////////////////////////
          make_airoplane();


          //////////////////////////////////////////////////////

          ///////////////////////////////////////////////////////
          ///////////////////////////////////////////////////////
      }
      public void AutoPilot(bool On){
          AutoPilotOn = On;
          if(On==true){
              Console.WriteLine("Автопилот включен\n");
          }
          else Console.WriteLine("Автопилот выключен\n");
      }
      public void Print_Altitude()
      {
          Console.WriteLine("Высота"+Altitude);
      }
      public virtual void Climb()
      {
              Altitude += increment;
      }
      public void Down()
      {
          Altitude -= increment;
      }
      public void  set_Altitude(int set_Altitude)
      {
              if (forsage == false)
              { 
                  increment = 1;
                  if (Altitude <= set_Altitude)
                  {
                      while (Altitude != set_Altitude||(AutoPilotOn==true&&Altitude==MaxAltitudeAuto))
                      {
                          Climb();

                      }
                  }
                  if (Altitude >= set_Altitude)
                  {
                      increment = 1;
                      while (Altitude != set_Altitude || Altitude <= 0||(AutoPilotOn==true&&Altitude==MinAltitudeAuto))
                      {
                          
                          Down();
                      }
                  }
              }
              if (forsage == true)
              {
                  increment = max_increment;
                  if (Altitude <= set_Altitude)
                  {
                      while (Altitude != set_Altitude||(AutoPilotOn==true&&Altitude==MaxAltitudeAuto))
                      {
                          Climb();
                      }
                  }
                  if (Altitude >= set_Altitude)
                  {
                      increment = 1;
                      while (Altitude != set_Altitude || Altitude <= 0 || (AutoPilotOn == true && Altitude == MinAltitudeAuto))
                      {
                          
                          Down();
                      }
                  }
              }
          
      }
  }

}
