using exercise.main;
Item test = new Item("BGLO", 0.49f, "Bagel", "Onion");
Inventory inventory = new Inventory();
inventory.inInventory("COFB");
Basket basket = new Basket();
basket.changeBasketSize(10);
for (int i = 0; i < 10; i++)
{
    basket.addItem("BGLO");
}
inventory.printMenu();