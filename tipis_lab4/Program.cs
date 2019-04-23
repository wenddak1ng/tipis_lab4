using System;

namespace lab_3 {
  class MainClass {
    static string selected;
    static int shot;
    static void Main(string[] args) {
      Console.Title = "Лабораторная работа 4";
      pulemet pul = new pulemet();
      while (true) {
        Console.WriteLine("Доступные действия: Выстрел / Ствол / Температура / Стоп / Остановить");
        Console.Write("Для продолжения выберите действие: ");
        selected = Console.ReadLine().ToLower();
        if (selected == "выстрел") {
          if (pul.Pause > DateTime.Now.Second) {
            Console.WriteLine("Данное действие в данный момент невозможно. Время перезарядки {0} секунд", pul.Pause - DateTime.Now.Second);
            return;
          }
          Console.Write("Введите количество выстрелов: ");
          shot = int.Parse(Console.ReadLine());
          Console.WriteLine("Текущая температура ствола {0}C", pul.Shot);
          int i = 0;
          if ((pul.Shot + (pul.nag1st * shot)) > pul.maxTst) {
            i = shot - ((pul.maxTst - pul.Shot) / pul.nag1st);
            shot = shot - i;
          }
          pul.Shot = shot; //++ temperature
          pul.Pause = shot; //set tick
          Console.WriteLine("Произведено {0} выстрелов", shot);
          Console.WriteLine("Время паузы: {0} секунд", pul.Pause - DateTime.Now.Second); 
          if (i > 0) {
            Console.WriteLine("Не произведено {0} выстрелов из-за перегрева ствола", i);
          }
        }
        else if (selected == "стоп") break;
        else if (selected == "температура") pul.CheckTemp();
        else if (selected == "ствол") pul.ChangeSt();
        else if (selected == "остановить") {
          Console.Write("Введите время паузы (в секундах): ");
          pul.Pause = int.Parse(Console.ReadLine());
        }
      }
    }
  }
}