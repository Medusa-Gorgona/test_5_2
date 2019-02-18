using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_5_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Set<int> set = new Set<int>();           
            set.Elements = new List<int>(new int[] { 1, 2, 3, 4 });
            set.Count = 4;
            Set<int> set2 = new Set<int>();
            set2.Elements = new List<int>() { 8, 2, 9, 4 };
            Set<int> set0 = new Set<int>();
            set0.Elements = new List<int>() { 0, -2, -23, 5, 1 };
            set.Add(5);
            set0.Remove(5);
            set0.Print();
            Set<string> set5 = new Set<string>();
             set5.Elements = new List<string>(new string[] { "a", "b", "c", "d"});
            Set<string> set6 = new Set<string>();
            set6.Elements = new List<string>(new string[] { "d", "e", "c", "g" });
            Set<string> set7 = new Set<string>();
            Set<Transport> sauto = new Set<Transport>();
            sauto.Elements = new List<Transport>();
            Transport[] transport = new Transport[5];
            transport[0] = new Transport("Рено", "Меган");
            transport[1] = new Transport("Лада", "Калина");
            transport[2] = new Transport("ГАЗ", "Газель");
            transport[3] = new Transport("Смарт", "Смарт");
            transport[4] = new Transport("ИЖ", "Спортивный");
            Transport[] trans2 = new Transport[5];
            trans2[0] = new Transport("Лада", "Калина");
            trans2[3] = new Transport("ГАЗ", "Газель");
            trans2[2] = new Transport("Dray-Деревянная", "Сельская");
            trans2[2] = new Transport("Смарт", "Смарт");
            Set<Transport> sauto2 = new Set<Transport>();
            sauto2.Elements = new List<Transport>();
            sauto.AddRange(transport);

            Set<int> set3 = new Set<int>();
            set3 = set + set2;
            set3.Print();
            set7 = set5 + set6;
            set7.Print();

            set3 = set * set2;
            set3.Print();
            set7 = set5 * set6;
            set7.Print();

            set3 = set - set2;
            set3.Print();
            set7 = set5 - set6;
            set7.Print();

            set3 = set % set2;
            set3.Print();
            set7 = set5 % set6;
            set7.Print();

            bool fls = set > set2;            
            bool tr = set0 < set;

            bool fl = set5 > set6;
            //bool gl = set0 < set;
            Console.ReadKey();
        }
    }
}
