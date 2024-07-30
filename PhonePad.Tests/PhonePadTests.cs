using NUnit.Framework;

namespace PhonePad.Tests
{
    [TestFixture]
    public class PhonePadTests
    {
        [Test]
        public void TestOldPhonePad()
        {
            Assert.AreEqual("E", PhonePad.OldPhonePad("33#"));
            Assert.AreEqual("B", PhonePad.OldPhonePad("227*#"));
            Assert.AreEqual("HELLO", PhonePad.OldPhonePad("4433555 555666#"));
            Assert.AreEqual("TURING", PhonePad.OldPhonePad("8 88777444666*664#"));
        }

        [Test]
        public void TestBackspace()
        {
            Assert.AreEqual("A", PhonePad.OldPhonePad("2*2#"));
            Assert.AreEqual("", PhonePad.OldPhonePad("2*#"));
        }

        [Test]
        public void TestPause()
        {
            Assert.AreEqual("AA", PhonePad.OldPhonePad("2 2#"));
            Assert.AreEqual("B C", PhonePad.OldPhonePad("22 22#"));
        }
    }
}
