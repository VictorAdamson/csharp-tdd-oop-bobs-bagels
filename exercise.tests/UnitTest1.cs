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
        Item result = basket.addItem("BGLE");//new Item ("BGLE", 0.49f, "Bagel", "Everything")
        Assert.That(basket.Contents.Contains(result));
        string expectedJson = JsonConvert.SerializeObject(expected);
        string resultJson = JsonConvert.SerializeObject(result);
        Assert.That(resultJson, Is.EqualTo(expectedJson));
    }
    //[Test] 
    //public void addNonexistantItemTest()
    //{
    //    Item result = basket.addItem(new Item ("BGLA", 0.49f, "Bagel", "Asphalt"));
    //    Assert.That()
    //}
    [Test]
    public void removeItemTest()
    {
        Item result = basket.addItem("BGLE");
        Assert.That(basket.Contents.Contains(result));
        basket.removeItem(result);
        Assert.That(!basket.Contents.Contains(result));
    }
    [Test]
    public void changeCapacitytest()
    {
        for(int i = 0; i < 10; i++)
        {
            basket.addItem("BGLE");
        }
        Assert.That(basket.Contents.Count, Is.EqualTo(6));
        basket.Contents.Clear();
        basket.changeBasketSize(10);
        for (int i = 0; i < 10; i++)
        {
            basket.addItem("BGLE");
        }
        Assert.That(basket.Contents.Count, Is.EqualTo(10));
    }
    [TestCase()]
    public void printTotalCostTest()
    {
        basket.Receipt.showTotal();
    }
}