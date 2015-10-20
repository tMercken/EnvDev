using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // AAA
            // 1. Arrange = on instancie
            Pupil p = new Pupil("bob",3);
            //2. Act => on utilise le systeme
            p.AddActivity(new Activity("env", true));
            p.AddEvaluation("env", 'd');

            //3. Assert => on compare les résultats obtenu et attentu
            char evaluation = p.GetEvaluation("env");
            Assert.AreEqual('d', evaluation);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod2()
        {
            // 1. Arrange = on instancie
            Pupil p = new Pupil("bob", 3);
            //2. Act => on utilise le systeme
            p.AddActivity(new Activity("env", true));
            p.AddEvaluation("env", 'd');

            //3. Assert => on compare les résultats obtenu et attentu
            char evaluation = p.GetEvaluation("lol");
            Assert.AreEqual('d', evaluation);
        }

    }
}
