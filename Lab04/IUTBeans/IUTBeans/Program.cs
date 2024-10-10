// See https://aka.ms/new-console-template for more information

using IUTBeans;

Beverage cappuccino = new Cappuccino();
Console.WriteLine(cappuccino);

Beverage espresso = new Espresso(new Milk(new WhippedCream()));
Console.WriteLine(espresso);

Beverage latte = new Latte(new Milk(new Milk(new WhiteSugar())));
Console.WriteLine(latte);