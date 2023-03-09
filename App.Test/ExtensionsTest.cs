using NUnit.Framework;


namespace App.Test
{
    public class ExtensionsTest
    {

        [Test]
        public void BasicOpenCloseBraces()
        {
            Assert.IsTrue("{}".BalancedBraces());
        }

        [Test]
        public void UnclosedBraces()
        {
            Assert.IsFalse("}{".BalancedBraces());
        }

        [Test]
        public void UnalancedPairBraces()
        {
            Assert.IsFalse("{{}".BalancedBraces());
        }

        [Test]
        public void NoBrackets()
        {
            Assert.IsTrue(@"""".BalancedBraces());
        }

        [Test]
        public void CharacterIgnored()
        {
            Assert.IsTrue("{abc...xyz}".BalancedBraces());
        }
    }
}