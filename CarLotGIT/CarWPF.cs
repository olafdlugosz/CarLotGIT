using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotGIT
{
    class CarWPF
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string RegNumber { get; set; }

        public CarWPF()
        {
            this.Model = "Unspecified";
            this.Make = "Unspecified";
            this.Year = 0;
            this.Color = "Unspecified";
            this.RegNumber = "Unspecifed";
        }

        public CarWPF(string Model, string Make, int Year, string Color, string RegNumber)
        {
            this.Model = Model;
            this.Make = Make;
            this.Year = Year;
            this.Color = Color;
            this.RegNumber = RegNumber;

        }

        public string DisplayCarInfo()
        {
            return String.Format("{0},{1},{2},{3},{4}", Model, Make, Year.ToString(), Color, RegNumber);
        }

    }
}
