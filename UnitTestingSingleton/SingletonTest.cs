using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace TestSingleton
{
    [TestFixture]
    public class SingletonTest
    {
        [SetUp]
        public void TestSetup()
        {
            Singleton.getInstance();
        }

        [Test]
        public void Singleton_value()
        {
            NUnit.Framework.Assert.NotNull(Singleton.Instance);
        }

        [Test]
        public void Singleton_null_value()
        {
            Singleton.resetForTesting();

            NUnit.Framework.Assert.IsNull(Singleton.Instance);
        }

        [Test]
        public void Singleton_field_test_has_value()
        {
            SomeClass someClass = new SomeClass(Singleton.Instance);

            bool condition=someClass.SomeLogic(3);

            NUnit.Framework.Assert.AreEqual(true, condition);
        }
    }
}
