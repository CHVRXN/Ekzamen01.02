using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class StudyCheckTests
    {
        [TestMethod()]
        public void Check_HasUpperCase_ReturnsTrue()
        {
            string lastname = "Davitskiy";
            string firstname = "Daniil";
            string fathername = "Dalentinovich";

            string fio = StudBilet.EnterName(lastname, firstname, fathername);

            string group = "195";
            string year = "2019";

            string bilet = StudBilet.GetStudNumber(year, group, fio);
            bool actual = StudyCheck.StudCheck(bilet, fio, year, group);

            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_Year4Sym_ReturnsTrue()
        {
            string lastname = "Savitskiy";
            string firstname = "Daniil";
            string fathername = "Valentinovich";
            string fio = StudBilet.EnterName(lastname, firstname, fathername); //

            string group = "195";//
            string year = "2019";
            string bilet = StudBilet.GetStudNumber(year, group, fio);
            bool actual = StudyCheck.StudCheck(bilet, fio, year, group);

            /*            int yearlength = year.Length;
                        if (yearlength < 4 || yearlength > 4) Assert.IsFalse(actual);*/

            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_Group3Sym_ReturnsTrue()
        {
            string lastname = "Savitskiy";
            string firstname = "Daniil";
            string fathername = "Valentinovich";
            string fio = StudBilet.EnterName(lastname, firstname, fathername); //

            string group = "195";//
            string year = "2019";
            string bilet = StudBilet.GetStudNumber(year, group, fio);
            bool actual = StudyCheck.StudCheck(bilet, fio, year, group);

            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_IsNull_ReturnsTrue()
        {
            string fio = ""; 
            string group = "123";
            string year = "1234";
            string bilet = "";

            try
            {
                string lastname = "Asdas";
                string firstname = "Asdas";
                string fathername = "Asdas";
                fio = StudBilet.EnterName(lastname, firstname, fathername);
            }
            catch (IndexOutOfRangeException)
            {
                bool actual = StudyCheck.StudCheck(bilet, fio, year, group);
                Assert.IsFalse(actual);
            }
            finally
            {
                bilet = StudBilet.GetStudNumber(year, group, fio);
                bool actual = StudyCheck.StudCheck(bilet, fio, year, group);
                bool expected = true;
                Assert.AreEqual(expected, actual);
            }
        }
    }
}