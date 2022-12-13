using Identity.BLL.Infrastructure;

namespace Identity.Test
{
    public class EncryptationTest
    {
      
        [Test]
        public void Successful_encryption()
        {
            var password = "123";
            var sut = new ReverceEncryptation();

            var result = sut.ToEncrypte(password);
            Assert.AreEqual("321", result);
        }

        [Test]
        public void Successful_unencryption()
        {
            var password = "123";
            var sut = new ReverceEncryptation();

            var result = sut.UnEncrypte(password);
            Assert.AreEqual("321", result);
        }
    }
}