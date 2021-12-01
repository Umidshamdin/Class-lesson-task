using System;

namespace classtask
{
    class Program
{
    static void Main(string[] args)
    {
            string email = "umidashhh@code.edu.az";
            string password = "12345";
            {
                if (email == ("umidash@code.edu.az") || password == "12345") 
                {
                    Console.WriteLine("Giris olundu");
                }
                else
                {
                    Console.WriteLine("Mail ve ya password sefhdi");
                }
            }


            int a = 13;


            int factorial = 1;
            for (int i = 1; i <= a; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(a + "!=" + factorial);



        }

    }
}
