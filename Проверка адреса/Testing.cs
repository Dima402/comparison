using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adress.Tests
{
    [TestClass]
    public class Testing
    {
        string Ulitsa = "Авиаторов";
        string path = @"G:\ИС1-31\Учебная практика\Adress\Адреса.txt";



        [TestMethod]

        public void Exist()
        {
            bool result = false;

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == Ulitsa)
                    {
                        result = true;
                        break;
                    }
                }
                
            }

            Adres c = new Adres();
            bool expected = true;
            bool actual = c.One(result);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void Status_Street()
        {
            bool result = false;

            if ((Ulitsa == "Авиаторов") || (Ulitsa == "Богдановича") || (Ulitsa == "Большая Октябрьская") || (Ulitsa == "Воинова") || (Ulitsa == "Гагарина") || (Ulitsa == "Декабристов") || (Ulitsa == "Депутатская") || (Ulitsa == "Жукова") || (Ulitsa == "Калинина") || (Ulitsa == "Костромская"))
            {
                result = true;
            }
            Adres c = new Adres();
            bool expected = true;
            bool actual = c.Two(result);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void Status_Area()
        {
            bool result = false;

            if ((Ulitsa == "Богоявленская") || (Ulitsa == "Волкова") || (Ulitsa == "Комсомольская") || (Ulitsa == "Красная") || (Ulitsa == "Карла Маркса") || (Ulitsa == "Мира") || (Ulitsa == "Октябрьская") || (Ulitsa == "Подвойского") || (Ulitsa == "Советская") || (Ulitsa == "Торговая") || (Ulitsa == "Труда") || (Ulitsa == "Челюскинцев") || (Ulitsa == "Юбилейная") || (Ulitsa == "Юности") || (Ulitsa == "Ярославль-Главный"))
            {
                result = true;
            }
            Adres c = new Adres();
            bool expected = true;
            bool actual = c.Three(result);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void Status_Avenue()
        {
            bool result = false;

            if ((Ulitsa == "Проспект Авиаторов") || (Ulitsa == "Дзержинского") || (Ulitsa == "Ленина") || (Ulitsa == "Ленинградский") || (Ulitsa == "Октября") || (Ulitsa == "Машиностроителей") || (Ulitsa == "Московский") || (Ulitsa == "Толбухина") || (Ulitsa == "Фрунзе"))
            {
                result = true;
            }
            Adres c = new Adres();
            bool expected = true;
            bool actual = c.Four(result);
            Assert.AreEqual(expected, actual);

        }



    }
}
