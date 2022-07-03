using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary1;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string lastname = "";
            string firstname = "";
            string fathername = "";

            string fio = StudBilet.EnterName(lastname, firstname, fathername);

            string group = "";

            string year = "";
            StudBilet.GetStudNumber(year, group, fio);

            Console.ReadKey();
        }
    }
}

