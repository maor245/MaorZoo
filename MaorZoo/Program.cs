


using MaorZoo;

Dog dog = new Dog() { Name = "Humos", Weight = 10 };
Cat cat = new Cat() { Name = "kitty", Weight = 5 };
Donkey donkey = new Donkey() { Name = "donkey", Weight = 20 };

List<Animal> animals = new List<Animal>() { dog, cat , donkey };
foreach (var item in animals)
{
    Console.WriteLine(  item.SayHello());
    Thread.Sleep(1000);
    //hello to github
}