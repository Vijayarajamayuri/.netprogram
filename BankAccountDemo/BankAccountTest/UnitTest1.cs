using BankAccountDemo;
using NUnit.Framework;


namespace BankAccountTest
{
   
     public class Tests
    {
        private BankAccount acc;
        [SetUp]
        public void Setup()
        {
            acc=new BankAccount(100, "sai sri");
        }

        [Test]
        public void DepositTest()
        {
            //Assert.Pass();
            double expect = 110.0;
            double actual = acc.deposit(10);
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void IntersetTest()
        {
            double expect = 110.0;
            double actual = acc.Calcinterest(10);
            Assert.AreEqual(expect, actual);
        }

    }
}