using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotGIT
{
    class CarLot
    {
        public List<CarWPF> carList;
        public string name { get; set; }
        public string adress { get; set; }


        public CarLot()
        {
            this.name = "Unspecified";
            this.adress = "Unspecified";

        }
        public CarLot(string name, string adress)
        {
            this.name = name;
            this.adress = adress;
            carList = new List<CarWPF>();
        }



    }
}



