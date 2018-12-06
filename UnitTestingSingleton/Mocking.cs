using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSingleton
{
    [TestFixture]
    public class Mocking
    {
        [Test]
        public void MockingSingleton()
        {
            var mock = new Mock<IMoq>();
            mock.Setup(x => x.SomeLogic(It.IsAny<int>())).Returns(()=>true);

            SomeClass someClass = new SomeClass(mock.Object);

            NUnit.Framework.Assert.AreEqual(true, someClass.SomeLogic(3));
        }
    }
}
