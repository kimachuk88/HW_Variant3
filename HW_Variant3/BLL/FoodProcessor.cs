using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW_Variant3
{
    [Serializable]
    public class FoodProcessor :IElectronics
    {
        private int power;
        private int programsqty;

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Producer")]
        public string Producer { get; set; }

        [XmlElement("Price")]
        public int Price { get; set; }

        [XmlElement("Power")]
        public int Power
        {
            get => power;
            set => power = Power;
        }

        [XmlElement("ProgramsQty")]
        public int ProgramsQty
        {
            get => programsqty;
            set => programsqty = ProgramsQty;
        }

        public FoodProcessor()
        {

        }
        
        public FoodProcessor(string name, string producer, int price, int power, int programsqty)
        {
            this.power = power;
            this.programsqty = programsqty;
            Name = name;
            Producer = producer;
            Price = price;
        }

    }
}
