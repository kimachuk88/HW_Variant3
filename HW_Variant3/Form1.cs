using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace HW_Variant3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
            definition.Text = "Визначити абстрактний клас (або інтерфейс) «Електроприлад» (назва, фірма, ціна). Визначити 3 похідні від нього класи: \n" +
                "«Порохотяг» (потужність, колір), «Пральна машина» (кількість програм, об’єм ), «Комбайн» (потужність, кількість функцій). \n" +
                "В текстовому файлі задано дані про 7 різних електроприладів. Зчитати дані в один масив і вивести у Файл1 всі електроприлади,  \n " +
                "посортовані за назвою із зазначенням їх кількості. Вивести у Файл2 список назв та  загальну вартість електроприладів вказаної фірми.";
        }



        Buttons firstButton = new Buttons();
        private void Button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            firstButton.ShowFoodProcessors(richTextBox1);
            firstButton.ShowVacuumCleaners(richTextBox1);
            firstButton.ShowWashingMashines(richTextBox1);

            Button2.Visible = true;

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            richTextBox1.Text += "\n\n";

            firstButton.CreateBigList(richTextBox1);
            firstButton.SortByQty(richTextBox1);

            button3.Visible = true;
            Button2.Visible = false;

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            richTextBox1.Text += "\n\n";
            firstButton.SortByPrice(richTextBox1);
            button3.Visible = false;
        }

    }

}
