using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Programm 
    {
        static void Main(string[] args)
        {
            var list = new List<Машины>();
            var t1 = new Машины("Трактор", 2549200);
            var t2 = new НаземныйТранстпорт("Танк", 24000000, 220);
            var t3 = new Авиасредство("Квадрокоптер", 25200, 5002);
            var t4 = new Истребитель("Истребитель-2000", 500000, 2500, 9);
            var t5 = new Самолет("Стрела", 9999999, 7990, 24);
            var t6 = new Вертолет("Вертолет", 8000000, 8000, false);
            var t7 = new ЛегковойАвтомобиль("Honda", 1200000, 290, true);
            var t8 = new Грузовик("Грузовик", 8599000, 200, 2200);
            list.Add(t1);
            list.Add(t2);
            list.Add(t3);
            list.Add(t4);
            list.Add(t5);
            list.Add(t6);
            list.Add(t7);
            list.Add(t8);
            foreach (var item in list)
            {
                Console.WriteLine(item.GetName());
            }
        }
    }
}
