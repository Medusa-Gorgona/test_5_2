using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_5_2
{
    internal class Transport
    {
        private string brand;
        private string model;
        public Transport()
        {
            brand = "transport";
            model = "driving";
    }
        string Brand { get; set; }
       string Model { get; set; }
        public Transport(string _brand, string _model)
        {
            Brand = _brand;
            Model = _model;
        }
            //public int Count { get; set; }
            //public Transport()
            //{
            //    Elements = new List<T>();
            //    Count = 0;
            //}

            public void AddnewTransport(string Brand, string Model)
        {
            
                AddnewTransport(Brand, Model);
           
        }
    }


}
