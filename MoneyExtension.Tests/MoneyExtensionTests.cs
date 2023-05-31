namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 279.98m;

        int cents = valor.ToCents();

        Assert.AreEqual(27998, cents);
    }
}