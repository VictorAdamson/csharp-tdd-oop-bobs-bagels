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
        Item result = basket.addItem(new Item("BGLE", 0.49f, "Bagel", "Everything"));
        Item dsdd = new Item("BGLO", 0.49f, "Bagel", "Onion");
        Assert.That(basket.Contents.Contains(result));
        basket.removeItem(result);
        Assert.That(!basket.Contents.Contains(result));
    }
    [Test]
    public void changeCapacitytest()
    {
        Item result = new Item("BGLE", 0.49f, "Bagel", "Everything");
        for(int i = 0; i < 10; i++)
        {
            basket.addItem(result);
        }
        Assert.That(basket.Contents.Count, Is.EqualTo(6));
        basket.changeBasketSize(10);
        for (int i = 0; i < 10; i++)
        {
            basket.addItem(result);
        }
        Assert.That(basket.Contents.Count, Is.EqualTo(10));
    }
    [Test]
    public void printTotalCostTest()
    {
        
    }
}