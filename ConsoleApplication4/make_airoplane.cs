using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aerodrom
{
   public class make_airoplane
    {
     public  make_airoplane()
       {
           int key;
           Console.WriteLine("Если Вы хотите создать:");
           Console.WriteLine("Боинг нажмите 1:");
           Console.WriteLine("Военный самолет нажмите 2:");
           Console.WriteLine("АН нажмите 3:\n");
           do
           {
               Console.WriteLine("Сделайте выбор -  \n");
               key = Convert.ToInt32(Console.ReadLine());
               if (key == 1)
               {
                   Console.WriteLine("Самолёт Боинг 747");
                   Boing boing747=new Boing("boing", 4, 986);
               }
               if(key==2){
                   Console.WriteLine("Военный самолёт");
                   Military BCP=new Military("BCP", 4, 500);
               }
               if (key == 3)
               {
                   Console.WriteLine("************************************************************");
                   Console.WriteLine("Вас вітають Українські авіалінії");
                   AH AHTOHOB = new AH("AHTOHOB", 6, 777);
               }
           }
           while (key > 3 && key < 0);
       }
            /////////////////////////////////////////////////////////////
        
    }
}
