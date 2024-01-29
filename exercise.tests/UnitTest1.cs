using System.Reflection.Emit;
using exercise.main;
using Newtonsoft.Json;

namespace exercise.tests;

public class Tests
{
    private int capacity = 6;
    Basket basket;
    Inventory inventory;
    [SetUp]
    public void Setup()
    {
        basket = new Basket();
        inventory = new Inventory();
    }
    [TestCase("BGLO", true)]
    [TestCase("COFB", true)]
    [TestCase("FILB", true)]
    [TestCase("FILX", true)]
    [TestCase("BGLS", true)]
    [TestCase("BGLA", false)]
    [TestCase("AKAK", false)]
    [TestCase("FILY", false)]
    public void inventoryCheckTest(string excpected, bool real)
    {
        Assert.That(inventory.inInventory(excpected).Equals(real));
    }
    [Test]
    public void addItemTest()
    {
        Item expected = new Item("BGLE", 0.49f, "Bagel", "Everything");
        Item result = basket.addItem(new Item ("BGLE", 0.49f, "Bagel", "Everything"));
        Assert.That(basket.Contents.Contains(result));
        string expectedJson = JsonConvert.SerializeObject(expected);
        string resultJson = JsonConvert.SerializeObject(result);
        Assert.That(resultJson, Is.EqualTo(expectedJson));
    }
    [Test]
    public void removeItemTest()
    {
        
    }
    [Test]
    public void changeCapacitytest()
    {
        
    }
    [Test]
    public void printTotalCostTest()
    {
        
    }
}