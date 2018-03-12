using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BddTests
{
    [TestFixture]
    public class SimpleTests
    {
        [Test]
        public void should_pass()
        {

        }

        [Test]
        public void should_fail()
        {
            Assert.That(4, Is.EqualTo(0));
        }
    }
}
