using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PsFirstNUnit;

namespace PsFirstNUnitUnitTests
{
    [TestFixture]
    public class AirlineMembershipNumberValidatorTests
    {
        [Test]
        public void ShouldValidateCorrectNumber()
        {
            var sut = new AirlineMembershipNumberValidator();
            Assert.That(sut.ValidityOf("A1234567"), Is.True);
        }

        [Test]
        public void ShouldInvalidateIncorrectNumber()
        {
            var sut = new AirlineMembershipNumberValidator();
            Assert.That(sut.ValidityOf("A123456"), Is.False);
        }
    }
}
