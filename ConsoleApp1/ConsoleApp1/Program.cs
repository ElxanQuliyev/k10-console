using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nomrenizi daxil edin:");
            string nomre = Console.ReadLine();

            string[] nomreler = new string[] { };

            Console.WriteLine("az 1,ru 2");
            byte dil = byte.Parse(Console.ReadLine());

            if (dil == 1)
            {
                bool evvel = true;
                while(evvel)
                {
                    evvel = false;
                    Console.WriteLine("Elaqe ucun 0");
                    Console.WriteLine("Tarifler 1");
                    Console.WriteLine("Xidmetler 2");
                    byte xidmetler = byte.Parse(Console.ReadLine());
                    if (xidmetler == 2)
                    {
                        Console.WriteLine("Evvele qayit 0");
                        Console.WriteLine("Odeme balans 1");
                        Console.WriteLine("SMS 2");
                        byte evc= byte.Parse(Console.ReadLine());
                        if(evc==0)
                        {
                            Console.WriteLine("Evvele qayitdi");
                            evvel = true;
                        }
                        else if(evc==2)
                        {
                            Console.WriteLine("SMS xidmetinden istifade olundu");
                        }
                    }
                }
            }
            else if(dil == 2)
            {
                Console.WriteLine("RusElaqe ucun 0");
                Console.WriteLine("RusTarifler 1");
                Console.WriteLine("RusXidmetler 2");
                byte xidmetler = byte.Parse(Console.ReadLine());
                if (xidmetler == 2)
                {
                    Console.WriteLine("RusEvvele qayit 0");
                    Console.WriteLine("RusOdeme balans 1");
                    Console.WriteLine("RusSMS 2");

                }
            }
            else
            {
                Console.WriteLine("Uygun reqem secilmeyib");
            }

            //21200,54541221,545454,4545215


            //4/11/1997 11:40:33 AM   

            //byte switch_on = byte.Parse(Console.ReadLine());
            //switch (switch_on)
            //{
            //    case 1:
            //        Console.WriteLine("1 daxil edilib");
            //        break;
            //    case 2:
            //        Console.WriteLine("2 daxil edilib");
            //        break;
            //    default:
            //        Console.WriteLine("Default");
            //        break;
            //}

            //         int[] massiv = new int[10] { 1, 2, 3, 4, 5,6,7,8,9,10 };
            //         massiv[0] = 5;
            //         foreach (int item in massiv)
            //         {
            //             //Console.WriteLine(item);
            //         }




            //         string[] mass = new string[] 
            //         { "1.sjdfhjh as","2.sdfgsdfgsdfg"};

            //         foreach (string item in mass)
            //         {
            //             Console.WriteLine(item);
            //         }

            //         int[,] a1 = new int[,] {
            //{0, 1, 2, 3,7} , 
            //{4, 5, 6, 7,8} ,
            //{8, 9, 10, 11,9}};
            //0
            //1
            //2
            //3
            //7
            //4
            //Console.WriteLine(a1.Length);
            //foreach (int item in a1)
            //{
            //    Console.WriteLine(item);
            //}



            DateTime dogumtarixi = DateTime.Parse(Console.ReadLine());
            int yas = DateTime.Now.Year - dogumtarixi.Year;

            int bugun = DateTime.Now.Day;
            int dogumgunu = dogumtarixi.Day;
            //Console.WriteLine(bugun);

            if (DateTime.Now.Month<dogumtarixi.Month)
            { 
                yas = yas-1;
            }
            else if(DateTime.Now.Month == dogumtarixi.Month)
            {
                if(dogumgunu > bugun)
                {
                    yas = yas - 1;
                }
            }
            Console.WriteLine("yasi=" + yas);
            int k = 0;

            while (k==0)
            {
                Console.WriteLine("cinsiniz:");
                string cinsi = Console.ReadLine();
                if (cinsi == "kisi" || cinsi == "qadin")
                {
                    k = 1;
                }
                else
                {
                    Console.WriteLine("cins düzgün daxil edilmeyib:");
                    break;
                }
                k=k-1;
                k--;
            }

           

            Console.WriteLine("Tevelludunuz:");


            Console.ReadKey();
        }
    }
}
