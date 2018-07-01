using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW_Variant3
{
    [Serializable]
    public class VacuumCleaner: IElectronics 
    {
        private int power;
        private string color;


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

        [XmlElement("Color")]
        public string Color
        {
            get => color;
            set => color = Color;
        }


        public VacuumCleaner()
        {

        }

        public VacuumCleaner(string name, string producer, int price, int power, string color)
        {
            this.power = power;
            this.color = color;
            Name = name;
            Producer = producer;
            Price = price;
        }

    }
}
