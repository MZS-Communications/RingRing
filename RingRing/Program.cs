using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RingRing
{
    class Program
    {
        const string Shalom = "0794230621";
        const string Nokuthula = "0727903126";
        const string Zaheerah = "0794081844";
        const string Zwane = "0824844860";
        const string Marimi = "0780925657";





        static void Main()

        {


            Program prog = new Program();
            prog.menu();


            Console.ReadKey();






        }
        public void menu()
        {
            int option = 0;
            Console.WriteLine("Press 1: to Dial a Cellphone Number");
            Console.WriteLine("Press 2: to Dial the Telephone Number");
           //Console.WriteLine("To Exit");
            option = Convert.ToInt32(Console.ReadLine());
            options(option);

        }
        public void options(int num)
        {
            Program main = new Program();
            switch (num)
            {
                case 1:
                    {
                        main.Cellphone();
                        break;
                    }
                case 2:
                    {
                        main.Telephone();
                        break;
                    }

                default:

                    break;
            }

        }
        public void Cellphone()
        {
            Console.WriteLine("Please Enter CellPhone Number");
            string phone = Console.ReadLine();



            string sub = phone.Substring(0, 3);
            Regex phonenumber = new Regex("\\d{3}\\d{3}\\d{4}");//For phone number in format 0000000000

            if (sub == "072" || sub == "079" || sub == "069" || sub == "073" || sub == "078")

            {
                if (phone == Zaheerah)
                {
                    Console.WriteLine("Sucessfully Dialed " + "Zaheerah");
                    Console.ReadLine();
                }

                if (phone == Zwane)
                {
                    Console.WriteLine("Sucessfully Dialed " + "Zwane");
                    Console.ReadLine();
                }
                if (phone == Shalom)
                {
                    Console.WriteLine("Sucessfully Dialed " + "Shalom");
                    Console.ReadLine();
                }

                if (phone == Nokuthula)
                {
                    Console.WriteLine("Sucessfully Dialed " + "Nokuthula");
                    Console.ReadLine();
                }


                if (phone == Marimi)
                {
                    Console.WriteLine("Sucessfully Dialed " + "Marimi");
                    Console.ReadLine();
                }




                //If Matching
                if (phonenumber.IsMatch(phone))

                {

                    Console.WriteLine("Successfully Dialed " + phone);
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine("Invalid CellPhone Number, Press Enter to try again");
                Console.ReadLine();
                Cellphone();


            }
            Console.ReadKey();
        }

        //Telephone
        public void Telephone()
        {
            Console.WriteLine("Please Enter Telephone Number");
            string phone = Console.ReadLine();

            string code = phone.Substring(0, 3);
            string rest3 = phone.Substring(3, 3);
            string rest4 = phone.Substring(6);



            string sub = phone.Substring(0, 3);
            Regex phonenumber = new Regex("\\d{3}\\d{3}\\d{4}");//For phone number in format 0000000000

            if (sub == "012" || sub == "011")

            {

                if (phonenumber.IsMatch(phone))

                {

                    Console.WriteLine("Successfully Dialed " + "(" + code + ") " + rest3 + "-" + rest4);
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Invalid Telephone Number, Press Enter to try again");
                    Console.ReadLine();
                    Telephone();



                }
            }
            

        }

    }
}

