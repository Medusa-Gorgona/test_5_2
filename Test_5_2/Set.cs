using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_5_2
{
    public class Set<T>
    {

        public List<T> Elements;
        public int Count { get; set; }


        public Set()
        {
            Elements = new List<T>();
            Count = 0;
        }
        public void AddRange(T newVal1)
        {
            Set<T> transport = new Set<T>();
            bool n = false;
            for (int j = 0; j < this.Count; j++)
            {
                if (Elements[j].Equals(newVal1))
                {
                    n = true;
                }
            }
            if (n == false)
            {


               this.Elements.AddRange(transport.Elements);
                
            }
        }

        public void Add(T newVal)
        {
            bool n = false;
            for (int j = 0; j < this.Count; j++)
            {
                if (Elements[j].Equals(newVal))
                {
                    n = true;
                }
            }
            if (n == false)
            {
                this.Elements.Add(newVal);
            }
        }

        

        public void Remove(T newVal)
        {
            Elements.Remove(newVal);
        }

        public void Print()
        {
            foreach (T element in this.Elements)
            {
                Console.Write($"{ element }  ");
            }
            Console.WriteLine();
        }


        public Set<T> Union(Set<T> set2)
        {
            Set<T> set3 = new Set<T>();
            IEnumerable<T> ElFin = this.Elements.Union(set2.Elements);
            set3.Elements.AddRange(ElFin);
            return set3;
        }

        public Set<T> Intersect(Set<T> set2)
        {
            Set<T> set3 = new Set<T>();
            IEnumerable<T> ElFin = Elements.Intersect(set2.Elements);
            set3.Elements.AddRange(ElFin);
            return set3;
        }

        public Set<T> Except(Set<T> set2)
        {
            Set<T> set3 = new Set<T>();
            IEnumerable<T> ElFin = Elements.Except(set2.Elements);
            set3.Elements.AddRange(ElFin);
            return set3;
        }

        public Set<T> SymmetricDifference(Set<T> set2)
        {
            Set<T> set3 = new Set<T>();
            IEnumerable<T> ElFin = Elements.Union(set2.Elements).Except(Elements.Intersect(set2.Elements));
            set3.Elements.AddRange(ElFin);
            return set3;
        }

        public bool IsSubsetOf(Set<T> set)
        {
            Set<T> set2 = new Set<T>();
            int count = 0;
            for (int i = 0; i < set2.Count; ++i)
            {
                for (int j = 0; j < set.Count; ++j)
                {
                    if (set2.Elements.Equals(set.Elements))
                    {
                        ++count;                    
                    }
                }
            }

            if (count == set2.Elements.Count)
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }

        public static Set<T> operator +(Set<T> first, Set<T> second)
        {
            Set<T> set_new = new Set<T>();
            set_new = first.Union(second);
            return set_new;
        }

        
        public static Set<T> operator *(Set<T> first, Set<T> second)
        {
            Set<T> set_intersect = new Set<T>();
            set_intersect = first.Intersect(second);
            return set_intersect;
        }

        public static Set<T> operator -(Set<T> first, Set<T> second)
        {
            Set<T> set_differnce = new Set<T>();
            set_differnce = first.Except(second);
            return set_differnce;
        }

       public static Set<T> operator %(Set<T> first, Set<T> second)
        {
            Set<T> set_sym = new Set<T>();
            set_sym = first.SymmetricDifference(second);
            return set_sym;
        }

        public static bool operator >(Set<T> first, Set<T> second)
        {
            return first.IsSubsetOf(second);
        }

        public static bool operator <(Set<T> first, Set<T> second)
        {
            return first.IsSubsetOf(second);
        }

    }

}

