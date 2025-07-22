using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Writing Methods

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Spotify Playlist *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Daft Punk - Varidis Quo");
            //Console.WriteLine("2-Kendrick Lamar - Count Me Out");
            //Console.WriteLine("3-Drake feat. J. Cole - First Person Shooter");
            //Console.WriteLine("4-Tame Impala - New Person Same Old Mistakes");
            //Console.WriteLine("5-Şiwan Perwer - Xanıma Min");
            //Console.WriteLine("6-Ciwan Haco - Kazacok");
            //Console.WriteLine();
            //Console.WriteLine("***************************");

            #endregion

            #region String Variables

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Murat";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Hans";
            //customerSurname = "Landa";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "heildeutchland@gmail.com";
            //district = "Germany";
            //city = "Berlin";

            //Console.WriteLine("**** Flight Attandance Card Generator ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            //Console.WriteLine("İnformation: " + customerPhone);
            //Console.WriteLine("Email Address: " + customerEmail);
            //Console.WriteLine("Address: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Dominic";
            //customerSurname = "Decoco";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "forzaitalia@gmail.com";
            //district = "İtalya";
            //city = "Sicily";

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            //Console.WriteLine("İnformation: " + customerPhone);
            //Console.WriteLine("Email Address: " + customerEmail);
            //Console.WriteLine("Address: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------");

            #endregion

            #region Int Variables

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** MENU  ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza:     " + pizzaPrice + " TL");
            Console.WriteLine("-----Coke:      " + cokePrice + " TL");
            Console.WriteLine("-----Lemonade:  " + lemonadePrice + " TL");
            Console.WriteLine("-----Fries:  " + friesPrice + " TL");
            Console.WriteLine("-----Water: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** MENU ****");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamgurgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamgurgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Price: " + totalHamgurgerPrice + " TL");
            Console.WriteLine("Pizza Price: " + totalPizzaPrice + " TL");
            Console.WriteLine("Fries Price: " + totalFriesPrice + " TL");
            Console.WriteLine("COoke Price: " + totalCokePrice + " TL");
            Console.WriteLine("Lemonade Price: " + totalLemonadePrice + " TL");
            Console.WriteLine("Water Price: " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamgurgerPrice + totalPizzaPrice + totalFriesPrice;

            Console.WriteLine("Total Price to Pay: " + totalPrice + " TL");

            #endregion

            Console.Read();
        }
    }
}