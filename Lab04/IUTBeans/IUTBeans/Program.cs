// See https://aka.ms/new-console-template for more information

using IUTBeans;

Beverage beverage1 = new Espresso();

ICondimentAdder adder = new MilkAdder(null);
beverage1 = adder.AddCondiment(beverage1);
Console.WriteLine(beverage1);

Beverage beverage2 = new Espresso();
ICondimentAdder adder2 = new MilkAdder(new MilkAdder(new WhiteSugarAdder(null)));
beverage2 = adder2.AddCondiment(beverage2);

Console.WriteLine(beverage2);