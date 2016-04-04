using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace NetflixUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        private void addtwo()
        {
            NetflixProject.Genre genre = new NetflixProject.Genre();
            string result;
            string hi = "hi";
            string sup = "sup";

            genre.addtitles(ref hi, ref sup, out result);

            Assert.AreEqual("hi sup", result);
        }

        [TestMethod]
        private void addlist()
        {
            List<string> list = new List<string>();
            list.Add("test1");
            list.Add("test2");

            string test = list[1];

            Assert.AreEqual(test, "test2");

        }

        [TestMethod]
        private void loop()
        {
            List<string> list = new List<string>();
            list.Add("test1");
            list.Add("test2");
            string test1;
            string test2;
            for (int i = 0; list[i].Length <= 1; i++)
            {
                if (i == 0)
                {
                    test1 = list[i];
                    Assert.AreEqual(test1, list[0]);
                }
                else if (i == 1)
                {
                    test2 = list[i];
                    Assert.AreEqual(test2, list[1]);
                }

            }
        }

        [TestMethod]
        private void Enumerabletest()
        {
            List<string> list = new List<string>();
            list.Add("test1");


        }

        private IEnumerable viewmenu(List<string> a)
        {
            for (int j = 0; j < 1; j--)
            {
                foreach (string i in a)
                {
                    yield return i;
                    Assert.AreEqual("test1", i);
                }
            }

        }

        [TestMethod]
        private void addinttostring()
        {
            int a = 1;
            string print;
            print = "this is a int " + a;
            Assert.AreEqual("this is a int 1", print);
        }

        int number = 0;

        [TestMethod]
        private void testflow()
        {

            testflowpart(number);
            Assert.AreEqual(number, 5);

        }
        private void testflowpart(int a)
        {
            number = a + 5;

        }

        [TestMethod]
        private void take5()
        {
            number = 7;
            testsubtraction(number);
            Assert.AreEqual(2, number);
        }

        private void testsubtraction(int a)
        {
            number = a - 5;

        }
        private string highscore = "im number:1";
        [TestMethod]
        private void removeint()
        {
            int index = highscore.IndexOf(":");
            string user = (index > 0 ? highscore.Substring(0, index) : "");
            Assert.AreEqual(user, "1");
        }




    }
}
