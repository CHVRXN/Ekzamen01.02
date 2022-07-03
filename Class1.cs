using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StudBilet
    {

        public static string EnterName(string lastname, string firstname, string fathername)
        {
            string fio = Convert.ToString(lastname[0]) + Convert.ToString(firstname[0]) + Convert.ToString(fathername[0]);
            return fio;
        } 
        static public string GetStudNumber(string year, string group, string fio)
        {
            string result = $"{year}.{group}.{fio}";
            Console.WriteLine("Студ. Билет: " + result);
            return result;
        }
    }
    public class StudyCheck
    {
        public static bool StudCheck(string bilet, string fio, string year, string group)
        {
        if (!(year.Length == 4))
        {
            return false;
        }
        if (!(group.Length == 3))
        {
            return false;
        }

        if (!fio.All(Char.IsUpper))
        {
            return false;
        }
        if (bilet == null)
        {
            return false;
        }

        return true;
        }

    }
}


    
