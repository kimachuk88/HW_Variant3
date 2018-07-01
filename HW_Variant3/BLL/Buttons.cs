using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HW_Variant3
{
    //Creating class Buttons with methods which will be opearatible by buttons in form
    [Serializable]
    public class Buttons
    {
        public string dir = Directory.GetCurrentDirectory();
        public class Nested
        {
            public string Brands { get; set; }
            public int Counter { get; set; }
            public int Count { get; set; }


            public Nested()
            {

            }
            public Nested(string brands, int counter)
            {
                Brands = brands;
                Counter = counter;
            }
            public Nested(int count, string brands)
            {
                Brands = brands;
                Count = count;
            }
        }
        private List<FoodProcessor> foodProcessors = new List<FoodProcessor>();
        private List<WashingMashine> washingMashines = new List<WashingMashine>();
        private List<VacuumCleaner> vacuumCleaners = new List<VacuumCleaner>();
        private List<IElectronics> bigList = new List<IElectronics>();
        private List<string> brands = new List<string>();
        private List<string> dist = new List<string>();
        private List<Nested> file1 = new List<Nested>();
        private List<Nested> file2 = new List<Nested>();

        //Testing lists
        public List<FoodProcessor> TestfoodProcessors = new List<FoodProcessor>();
        public List<WashingMashine> TestWashingMashines = new List<WashingMashine>();
        public List<VacuumCleaner> TestVacuumCleaners = new List<VacuumCleaner>();

        //Reading from file
        public void OpenFile()
        {
            XmlDocument xmlDocument = new XmlDocument();
            try
            {
                xmlDocument.Load("C:\\Users\\HP DV2 - 1030us\\source\\repos\\HW_Variant3\\HW_Variant3\\bin\\Debug\\Info.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return;
            }

            //Locating where to start reading in XML file
            XmlNodeList nodeElectronics = xmlDocument.GetElementsByTagName("Electronics");
            XmlNodeList nodeList = xmlDocument.SelectNodes("/root/Electronics/FoodProcessors/FoodProcessor");

            //Looping to add all Food Processors to list
            try
            {

                foreach (XmlElement xmlNode in nodeList)
                {
                    string name = xmlNode["Name"].InnerText;
                    string producer = xmlNode["Producer"].InnerText;
                    int price = Convert.ToInt32(xmlNode["Price"].InnerText);
                    int power = Convert.ToInt32(xmlNode["Power"].InnerText);
                    int programsqty = Convert.ToInt32(xmlNode["ProgramsQty"].InnerText);


                    foodProcessors.Add(new FoodProcessor(name, producer, price, power, programsqty));
                    TestfoodProcessors.Add(new FoodProcessor(name, producer, price, power, programsqty));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return;
            }

            nodeList = xmlDocument.SelectNodes("/root/Electronics/VacuumCleaners/VacuumCleaner");

            //Looping to add all Vacuum Cleaners to list
            try
            {
                foreach (XmlElement xmlNode in nodeList)
                {
                    string name = xmlNode["Name"].InnerText;
                    string producer = xmlNode["Producer"].InnerText;
                    int price = Convert.ToInt32(xmlNode["Price"].InnerText);
                    int power = Convert.ToInt32(xmlNode["Power"].InnerText);
                    string color = xmlNode["Color"].InnerText;


                    vacuumCleaners.Add(new VacuumCleaner(name, producer, price, power, color));
                    TestVacuumCleaners.Add(new VacuumCleaner(name, producer, price, power, color));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return;
            }
            nodeList = xmlDocument.SelectNodes("/root/Electronics/WashingMashines/WashingMashine");

            //Looping to add all Washing Mashines to list

            try
            {
                foreach (XmlElement xmlNode in nodeList)
                {
                    string name = xmlNode["Name"].InnerText;
                    string producer = xmlNode["Producer"].InnerText;
                    int price = Convert.ToInt32(xmlNode["Price"].InnerText);
                    int programsqty = Convert.ToInt32(xmlNode["ProgramsQty"].InnerText);
                    int volume = Convert.ToInt32(xmlNode["Volume"].InnerText);


                    washingMashines.Add(new WashingMashine(name, producer, price, programsqty, volume));
                    TestWashingMashines.Add(new WashingMashine(name, producer, price, programsqty, volume));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return;
            }
        }

        //Extracting to show Food Processors
        public void ShowFoodProcessors(RichTextBox richTextBox1)
        {
            try
            {
                richTextBox1.Text += " Electronics \n Food Processors:\n";
                OpenFile();
                foreach (var item in foodProcessors)
                {
                    richTextBox1.Text += ($"{item.Producer} - {item.Name} - {item.Price} UAH    {item.Power} Watts   {item.ProgramsQty} Programs");
                    richTextBox1.Text += "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return;
            }
        }

        //Extracting to show Washing Mashines
        public void ShowWashingMashines(RichTextBox richTextBox1)
        {
            try
            {
                richTextBox1.Text += "\n Washing Mashines:\n";
                foreach (var item in washingMashines)
                {
                    richTextBox1.Text += ($"{item.Producer} - {item.Name} - {item.Price} UAH    {item.Volume} Kg   {item.ProgramsQty} Programs");
                    richTextBox1.Text += "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return;
            }
        }

        //Extracting to show Vacuum Cleaners
        public void ShowVacuumCleaners(RichTextBox richTextBox1)
        {
            try
            {
                richTextBox1.Text += "\n Vacuum Cleaners:\n";
                foreach (var item in vacuumCleaners)
                {
                    richTextBox1.Text += ($"{item.Producer} - {item.Name} - {item.Price} UAH    {item.Power} Watts   {item.Color} Color");
                    richTextBox1.Text += "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return;
            }
        }

        //Creating one list of Electronics(bigList)
        public void CreateBigList(RichTextBox richTextBox1)
        {
            bigList.AddRange(foodProcessors);
            bigList.AddRange(washingMashines);
            bigList.AddRange(vacuumCleaners);
        }

        //Finding distinct producers names and adding it to brands.list
        public void SortByQty(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "\n---------Sorted by QTY-------------------";
            try
            {
                foreach (var item in bigList.Distinct())
                {

                    dist.Add(item.Producer);
                }
                dist = dist.Distinct().ToList();

                dist.Sort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return;
            }

            try
            {
                foreach (var item in dist)
                {
                    brands.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return;
            }
            int counter = 0;

            //Finding how many times each producer appears in list of Electronics(bigList)
            //And adding it to list amountofProducers
            List<int> amountProducer = new List<int>();
            try
            {
                for (int i = 0; i < dist.Count; i++)
                {
                    for (int j = 0; j < bigList.Count; j++)
                    {
                        if (bigList[j].Producer == dist[i])
                        {
                            counter++;
                        }

                    }
                    amountProducer.Add(counter);
                    richTextBox1.Text += "\n" + brands[i] + " - " + counter + " Pcs.";
                    file1.Add(new Nested(brands[i], counter));
                    counter = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return;
            }

            //Creating XML file for file1.list
            try
            {
                var Exle = new XElement("Sorted_by_quantity",
                            from fil in file1
                            select new XElement("Brand",
                            new XAttribute("Name", fil.Brands),
                            new XElement("Qty", fil.Counter)));
                Exle.Save("File1.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return;
            }
        }

        //Finding distinct producers items cost and adding it to priceProducer.list
        public void SortByPrice(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "\n---------Sorted by Price-------------------";
            int sum = 0;
            List<int> priceProducer = new List<int>();
            try
            {
                for (int i = 0; i < dist.Count; i++)
                {
                    for (int j = 0; j < bigList.Count; j++)
                    {
                        if (bigList[j].Producer == dist[i])
                        {
                            sum += bigList[j].Price;
                        }
                    }
                    priceProducer.Add(sum);
                    richTextBox1.Text += "\n" + brands[i] + " - " + sum + " UAH";
                    file2.Add(new Nested(sum, brands[i]));
                    sum = 0;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return;
            }
            //Creating XML file for file1.list
            try
            {
                var Exle = new XElement("Sorted_by_price",
                            from fil in file2
                            select new XElement("Brand",
                            new XAttribute("Name", fil.Brands),
                            new XElement("Total_price", fil.Count)));
                Exle.Save("File2.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return;
            }
        }


    }

}



