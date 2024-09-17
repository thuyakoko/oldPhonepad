
using NUnit.Framework;

[TestFixture]
public class OldPhonePadTests
{
    [Test]
    public void TestSingleKeyPress()
    {
        Assert.AreEqual("E", OldPhonePadSimulator.OldPhonePad("33#"));
    }

    [Test]
    public void TestWithBackspace()
    {
        Assert.AreEqual("B", OldPhonePadSimulator.OldPhonePad("227*#"));
    }

    [Test]
    public void TestLongerInput()
    {
        Assert.AreEqual("HELLO", OldPhonePadSimulator.OldPhonePad("4433555 555666#"));
    }

    [Test]
    public void TestWithMultiplePausesAndBackspace()
    {
        Assert.AreEqual("TOOL", OldPhonePadSimulator.OldPhonePad("8 88777444666*664#"));
    }

    [Test]
    public void TestEdgeCaseEmptyInput()
    {
        Assert.AreEqual("", OldPhonePadSimulator.OldPhonePad("#"));
    }

    [Test]
    public void TestEdgeCaseOnlyBackspace()
    {
        Assert.AreEqual("", OldPhonePadSimulator.OldPhonePad("*#"));
    }

    [Test]
    public void TestInvalidInputs()
    {
        Assert.AreEqual("A", OldPhonePadSimulator.OldPhonePad("2#"));
        Assert.AreEqual("", OldPhonePadSimulator.OldPhonePad("****#"));
    }
}
