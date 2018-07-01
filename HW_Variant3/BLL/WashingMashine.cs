using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW_Variant3
{
    [Serializable]
    public class WashingMashine: IElectronics
    {
        
        private int programsqty;
        private int volume;

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Producer")]
        public string Producer { get; set; }

        [XmlElement("Price")]
        public int Price { get; set; }

        [XmlElement("ProgramsQty")]
        public int ProgramsQty
        {
            get => programsqty;
            set => programsqty = ProgramsQty;
        }

        [XmlElement("Volume")]
        public int Volume
        {
            get => volume;
            set => volume = Volume;
        }

        public WashingMashine()
        {

        }

        public WashingMashine(string name, string producer, int price, int programsqty, int volume)
        {
            this.programsqty = programsqty;
            this.volume = volume;
            Name = name;
            Producer = producer;
            Price = price;
        }
    }
}
