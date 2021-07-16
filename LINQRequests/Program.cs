using System;
using System.Linq;

namespace LINQRequests
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while(true) {
                Console.WriteLine("Do you want to end?(Y)");
                var check = Console.ReadLine();
                if (check == "y"||check=="Y")
                {
                    break;
                }
                Console.WriteLine("Choose animal");
                Console.WriteLine("1-Animal, 2-Lion, 3-Zebra, 4-Giraffe");
                //TODO ind make to if
                int ind = int.Parse(Console.ReadLine());

                Console.WriteLine("Write name:");
                string name = Console.ReadLine();

                Console.WriteLine("Write color:");
                string color = Console.ReadLine();

                Console.WriteLine("Write age:");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Write country:");
                string country = Console.ReadLine();

                using (var db = new Context())
                {
                    if (ind == 1)
                    {
                        var animal = new Animal()
                        {
                            Name = name,
                            Color = color,
                            Age = age,
                            Country = country
                        };
                        db.Add(animal);
                        db.SaveChanges();
                    }
                    else if (ind == 2)
                    {
                        var lion = new Lion()
                        {
                            Name = name,
                            Color = color,
                            Age = age,
                            Country = country
                        };
                        db.Add(lion);
                        db.SaveChanges();
                    }
                    else if (ind == 3)
                    {
                        var zebra = new Zebra()
                        {
                            Name = name,
                            Color = color,
                            Age = age,
                            Country = country
                        };
                        db.Add(zebra);
                        db.SaveChanges();
                    }
                    else if (ind == 4)
                    {
                        var giraffe = new Giraffe()
                        {
                            Name = name,
                            Color = color,
                            Age = age,
                            Country = country
                        };
                        db.Add(giraffe);
                        db.SaveChanges();
                    }
                }
            };
            
            while (true)
            {
                Console.WriteLine("Choose table");
                Console.WriteLine("1-Animal, 2-Lion, 3-Zebra, 4-Giraffe");

                int ind = int.Parse(Console.ReadLine());
                             
                Console.WriteLine("What do you want to do with table?");
                Console.WriteLine("1-Order by, 2-Average, 3-Condition, 4-Select");
                if(!int.TryParse(Console.ReadLine(),out int option))
                {
                    Console.WriteLine("Error input...");
                    option = 0;
                }
                
                using (var db = new Context())
                {
                    switch (ind)
                    {
                        case 1:
                            if (option == 1)
                            {
                                var result = db.Animals.OrderBy(animal=>animal.Age);
                                foreach (var item in result)
                                {
                                    Console.WriteLine($"{item.Id} {item.Name} {item.Age} {item.Color} {item.Country}");
                                }
                            }
                            else if (option == 2)
                            {
                                var result = db.Animals.Average(animal => animal.Age);
                                Console.WriteLine($"{result}");
                            }
                            else if (option == 3)
                            {
                                Console.WriteLine("Size:");
                                if (!int.TryParse(Console.ReadLine(), out int check))
                                {
                                    Console.WriteLine("Error size...");
                                }
                                else
                                {
                                    Console.WriteLine("What do you want condition?(<,>,==)");
                                    var asign = Console.ReadLine();
                                    if (asign == "==")
                                    {
                                        var result = db.Animals.Where(animal => animal.Age == check);
                                        foreach (var item in result)
                                        {
                                            Console.WriteLine($"{item.Id} {item.Name} {item.Age} {item.Color} {item.Country}");
                                        }
                                    }
                                    else if (asign == ">")
                                    {
                                        var result = db.Animals.Where(animal => animal.Age > check);
                                        foreach (var item in result)
                                        {
                                            Console.WriteLine($"{item.Id} {item.Name} {item.Age} {item.Color} {item.Country}");
                                        }
                                    }
                                    else if (asign == "<")
                                    {
                                        var result = db.Animals.Where(animal => animal.Age < check);
                                        foreach (var item in result)
                                        {
                                            Console.WriteLine($"{item.Id} {item.Name} {item.Age} {item.Color} {item.Country}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error condition...");
                                    }
                                }
                            }
                            else if (option == 4)
                            {
                                var result = db.Animals.Select(animal => animal.Name);
                                foreach (var item in result)
                                {
                                    Console.WriteLine($"{item}");
                                }
                            }
                            break;
                        case 2:
                            if (option == 1)
                            {
                                var result = db.Lions.OrderBy(animal=>animal.Age);
                                foreach (var item in result)
                                {
                                    Console.WriteLine($"{item.Id} {item.Name} {item.Age} {item.Color} {item.Country}");
                                }
                            }
                            else if (option == 2)
                            {
                                var result = db.Lions.Average(animal => animal.Age);
                                Console.WriteLine($"{result}");
                            }
                            else if (option == 3)
                            {
                                //TODO check make to if
                                Console.WriteLine("Size:");
                                int check = int.Parse(Console.ReadLine());
                                Console.WriteLine("What do you want condition?(<,>,==)");
                                var asign = Console.ReadLine();
                                if (asign == "==")
                                {
                                    var result = db.Lions.Where(animal => animal.Age == check);
                                    foreach (var item in result)
                                    {
                                        Console.WriteLine($"{item.Id} {item.Name} {item.Age} {item.Color} {item.Country}");
                                    }
                                }
                                else if (asign == ">")
                                {
                                    var result = db.Lions.Where(animal => animal.Age > check);
                                    foreach (var item in result)
                                    {
                                        Console.WriteLine($"{item.Id} {item.Name} {item.Age} {item.Color} {item.Country}");
                                    }
                                }
                                else if (asign == "<")
                                {
                                    var result = db.Lions.Where(animal => animal.Age < check);
                                    foreach (var item in result)
                                    {
                                        Console.WriteLine($"{item.Id} {item.Name} {item.Age} {item.Color} {item.Country}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Error condition...");
                                }

                            }
                            else if (option == 4)
                            {
                                var result = db.Animals.Select(animal => animal.Name);
                                foreach (var item in result)
                                {
                                    Console.WriteLine($"{item}");
                                }
                            }
                            break;
                        case 3:
                            if (option == 1)
                            {
                                var result = db.Zebras.OrderBy(animal=>animal.Age);
                                foreach (var item in result)
                                {
                                    Console.WriteLine($"{item.Id} {item.Name} {item.Age} {item.Color} {item.Country}");
                                }
                            }
                            else if (option == 2)
                            {
                                var result = db.Zebras.Average(animal => animal.Age);
                                
                                Console.WriteLine($"{result}");
                                 
                            }
                            else if (option == 3)
                            {
                                //TODO check make to if
                                Console.WriteLine("Size:");
                                int check = int.Parse(Console.ReadLine());
                                Console.WriteLine("What do you want condition?(<,>,==)");
                                var asign = Console.ReadLine();
                                if (asign == "==")
                                {
                                    var result = db.Zebras.Where(animal => animal.Age == check);
                                    foreach (var item in result)
                                    {
                                        Console.WriteLine($"{item.Id} {item.Name} {item.Age} {item.Color} {item.Country}");
                                    }
                                }
                                else if (asign == ">")
                                {
                                    var result = db.Zebras.Where(animal => animal.Age > check);
                                    foreach (var item in result)
                                    {
                                        Console.WriteLine($"{item.Id} {item.Name} {item.Age} {item.Color} {item.Country}");
                                    }
                                }
                                else if (asign == "<")
                                {
                                   var result = db.Zebras.Where(animal => animal.Age < check);
                                    foreach (var item in result)
                                    {
                                        Console.WriteLine($"{item.Id} {item.Name} {item.Age} {item.Color} {item.Country}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Error condition...");
                                }

                            }
                            else if (option == 4)
                            {
                                var result = db.Zebras.Select(animal => animal.Name);
                                foreach (var item in result)
                                {
                                    Console.WriteLine($"{item}");
                                }
                            }
                            break;
                        case 4:
                            if (option == 1)
                            {
                                var result = db.Giraffes.OrderBy(animal=>animal.Age);
                                foreach (var item in result)
                                {
                                    Console.WriteLine($"{item.Id} {item.Name} {item.Age} {item.Color} {item.Country}");
                                }
                            }
                            else if (option == 2)
                            {
                                var result = db.Giraffes.Average(animal => animal.Age);
                                Console.WriteLine($"{result}");
                            }
                            else if (option == 3)
                            {
                                //TODO check make to if
                                Console.WriteLine("Size:");
                                int check = int.Parse(Console.ReadLine());
                                Console.WriteLine("What do you want condition?(<,>,==)");
                                var asign = Console.ReadLine();
                                if (asign == "==")
                                {
                                    var result = db.Giraffes.Where(animal => animal.Age == check);
                                }
                                else if (asign == ">")
                                {
                                    var result = db.Giraffes.Where(animal => animal.Age > check);
                                    foreach (var item in result)
                                    {
                                        Console.WriteLine($"{item.Id} {item.Name} {item.Age} {item.Color} {item.Country}");
                                    }
                                }
                                else if (asign == "<")
                                {
                                    var result = db.Giraffes.Where(animal => animal.Age < check);
                                    foreach (var item in result)
                                    {
                                        Console.WriteLine($"{item.Id} {item.Name} {item.Age} {item.Color} {item.Country}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Error condition...");
                                }

                            }
                            else if (option == 4)
                            {
                                var result = db.Giraffes.Select(animal => animal.Name);
                                foreach (var item in result)
                                {
                                    Console.WriteLine($"{item}");
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Error choose table...");
                            break;
                    }
                }
                Console.WriteLine("Do you want to end?(Y)");
                var end = Console.ReadLine();
                if(end == "y" || end == "Y")
                {
                    break;
                }
            }
        }
    }
}
