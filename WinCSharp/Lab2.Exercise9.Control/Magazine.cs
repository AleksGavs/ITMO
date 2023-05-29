using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITMO2023.WinCSharp.Lab9
{
    class Magazine : Item, IPubs
    {
        private int volume;    // том
        private int number;        // номер
        private String title;       // название
        private DateTime year;      // дата выпуска

        public bool IfSubs { get; set; } // подписка на журнал

        public Magazine(int volume, int number, String title, DateTime year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }


       public override void Return()    // операция "вернуть"
       {
           taken = true;
       }

        // реализация интерфейса

      

      public void Subs()
      {
          // действия при оформлении подписки на журнал
      }


       public override string ToString()
       {
           if (IfSubs)
           return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
           "\n Номер: " + number + "\nГод выпуска: " + year.ToShortDateString() + "\n Подписка оформлена";
           else
               return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
           "\n Номер: " + number + "\nГод выпуска: " + year.ToShortDateString() + "\n Подписка не оформлена"; ;
       }
    }
}
