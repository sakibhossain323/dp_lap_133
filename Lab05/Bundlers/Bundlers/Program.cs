// See https://aka.ms/new-console-template for more information

using Bundlers;

IProduct laptop = new Laptop();
Console.WriteLine(laptop.getDetails()+": "+laptop.getPrice());

IProduct bundle1 = new KeyboardMouseBundle();
Console.WriteLine(bundle1.getDetails()+": "+ bundle1.getPrice());

IProduct bundle2 = new LaptopBundle();
Console.WriteLine(bundle2.getDetails()+": "+ bundle2.getPrice());