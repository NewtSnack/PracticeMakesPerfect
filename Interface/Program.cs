using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;


namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class 17");//File System, File, DirectoryInfo, FileInfo, FileStream, StreamWriter
                                          //Stream Reader, BinaryWriter, BinaryReader

            DirectoryInfo currDir = new DirectoryInfo(".");
            DirectoryInfo DarDir = new DirectoryInfo(@"C:\Users\Dar");
            Console.WriteLine(DarDir.FullName);
            Console.WriteLine(DarDir.Name);
            Console.WriteLine(DarDir.Parent);
            Console.WriteLine(DarDir.Attributes);
            Console.WriteLine(DarDir.CreationTime);
            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\darrc\Documents\C#Data");
            string[] customers2 =
            {
                "Bob Smith",
                "Sally Smith",
                "Robert Smith"
            };
            string textFilePath = @"C:\Users\darrc\Documents\CData\testfile1.txt";
            string textFilePathL = @"C:\Users\Dar\Documents\CSharptestfiles\testfile1.txt";

            File.WriteAllLines(textFilePathL, customers2);
            foreach (string cust in File.ReadAllLines(textFilePathL))
            {
                Console.WriteLine($"Customer : {cust}");
            }

            DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\Dar\Documents\CSharptestfiles\");

            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            Console.WriteLine("Matches : {0}", txtFiles.Length);
            foreach (FileInfo file in txtFiles)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }

            string textFilePath2 = @"C:\Users\darrc\Documents\CData\testfile2.txt";
            string textFilePath2L = @"C:\Users\Dar\Documents\CSharptestfiles\testfile2.txt";


            FileStream fs = File.Open(textFilePath2L, FileMode.Create);
            string randString = "This is a random string";
            byte[] rsByteArray = Encoding.Default.GetBytes(randString);

            fs.Write(rsByteArray, 0, rsByteArray.Length);
            fs.Position = 0;
            byte[] fileByteArray = new byte[rsByteArray.Length];
            for (int q = 0; q < rsByteArray.Length; q++)
            {
                fileByteArray[q] = (byte)fs.ReadByte();
            }
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));
            fs.Close();
            string textFilePath3 = @"C:\Users\darrc\Documents\CData\testfile3.txt";
            string textFilePath3L = @"C:\Users\Dar\Documents\CSharptestfiles\testfile3.txt";

            StreamWriter sw = File.CreateText(textFilePath3L);
            sw.Write("This is a random ");
            sw.WriteLine("sentence");
            sw.WriteLine("This is another sentence");
            sw.Close();

            StreamReader sr = File.OpenText(textFilePath3L);
            Console.WriteLine("Peek : {0}", Convert.ToChar(sr.Peek()));
            Console.WriteLine("1st String : {0}", sr.ReadLine());
            Console.WriteLine("Everything : {0}", sr.ReadToEnd());
            sr.Close();

            string textFilePath4L = @"C:\Users\Dar\Documents\CSharptestfiles\testfile4.dat";

            FileInfo datFile = new FileInfo(textFilePath4L);
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            string randText = "Random Text";
            int myAge = 42;
            double height = 6.25;

            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(height);

            bw.Close();

            BinaryReader br = new BinaryReader(datFile.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
            br.Close();

            Console.ReadLine();
            Console.WriteLine("Class 15");//LINQ, From, Where, Orderby, Select, IEnumerable, Inner Joins and Group Joins
            QueryStringArray();
            QueryIntArray();
            QueryArrayList();
            Console.ReadKey();
            Console.WriteLine("Class 14"); //Custom Collections, Indexers, Enumerator, Operator Overloading, Custom Casting, Anonymous Types
            ShoeFarm myShoes = new ShoeFarm();
            myShoes[0] = new Shoe("Puma");
            myShoes[1] = new Shoe("Jordan");
            myShoes[2] = new Shoe("Sketchers");
            myShoes[3] = new Shoe("Vans");
            foreach (Shoe item in myShoes)
            {
                Console.WriteLine(item.Name);
            }

            Box box1 = new Box(2, 3, 4);
            Box box2 = new Box(5, 6, 7);

            Box box3 = box1 + box2;
            Console.WriteLine($"Box 3 : {box3}");

            Console.WriteLine($"Box Int : {(int)box3}");

            Box box4 = (Box)4;
            Console.WriteLine($"Box 4 : {(Box)4}");

            var shopkins = new { Name = "Shopkins", Price = 4.99 }; //Anon Types
            Console.WriteLine("{0} cost ${1}", shopkins.Name, shopkins.Price);

            var toyArray = new[] { new { Name = "Yo-Kai Pack", Price = 4.99 }, new { Name = "Legos", Price = 9.99 } };

            foreach (var item in toyArray)
            {
                Console.WriteLine("{0} costs ${1}", item.Name, item.Price);
            }

            Console.ReadLine();
            //public private, protected Constants, Read-Only, Constructors, Setters, Getters, Properties and Static Fields
            Console.WriteLine("Class 6");
            Animal cat = new Animal();
            cat.SetName("Whiskers");
            cat.Sound = "Meow";

            Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);
            cat.Owner = "Derek";

            Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner); 
            Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);
            Console.WriteLine("# of Animals : {0}", Animal.NumOfAnimals); //static var belong to class

            Animal fox = new Animal("Oscar", "Whatthefoxsaaaaay");
            Console.WriteLine("# of Animals : {0}", Animal.NumOfAnimals);



            Console.ReadKey(true);

            Console.WriteLine("Class 10");
            Vehicle buick = new Vehicle("Buick", 4, 160);

            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven", buick.Brand);
            }
            IElectronicDevice TV = TVRemote.GetDevice();
            IElectronicDevice DVDPlayer = DVDPlayerRemote.GetDevice();


            PowerButton powBut = new PowerButton(TV);
            powBut.Execute();
            powBut.Undo();

            PowerButton powBut2 = new PowerButton(DVDPlayer);
            powBut2.Execute();

            Console.ReadLine();

            //Protected, Inheritance, Delegates, Super Classes, Polymorphism, Virtual, Override, Inner Classes 
            Console.WriteLine("Class 7");
            AnimalSealed whiskers = new AnimalSealed()
            {
                Name = "Whiskers",
                Sound = "Meow"

            };
            Dog grover = new Dog()
            {
                Name = "Groover",
                Sound = "Woof",
                Sound2 = "Bark"

            };

            //grover.Sound = "WOOOOOOOOOOOOOF";

            whiskers.MakeSound();
            grover.MakeSound();

            whiskers.SetAnimalIDInfo(12345, "Sally Su");
            grover.SetAnimalIDInfo(12346, "Jimmy James");

            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();

            AnimalSealed.AnimalHealth getHealth = new AnimalSealed.AnimalHealth();
            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11,146));

            AnimalSealed monkey = new AnimalSealed()
            {
                Name = "Happy",
                Sound = "Eeeeee"
            };

            AnimalSealed spot = new Dog() //polymorphism
            {
                Name = "Spot",
                Sound = "Wooof",
                Sound2 = "Geeeerr"
            };

            monkey.MakeSound();
            spot.MakeSound(); // use virtual to make this call the correct MakeSound();



            Console.ReadLine();

            Console.WriteLine("Class 8");
            //OOP Fighting
            Warrior maximus = new Warrior("Maximus", 1000, 120, 40);
            Warrior bob = new Warrior("Bob", 1000, 120, 40);
            Battle.StartFight(maximus, bob);
            Console.ReadLine();

            Console.WriteLine("Class 9");
            //Abstract classes, Abstract Methods, Base Classes, Is As, Casting, Polymorphism
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

            foreach(Shape s in shapes)
            {
                s.getInfo();
                Console.WriteLine("The {0} Area : {1:f2}", s.Name, s.Area());
                Circle testCirc = s as Circle;
                if (testCirc == null)
                {
                    Console.WriteLine("This isn't a Circle");
                }
                if(s is Circle)
                {
                    Console.WriteLine("This isn't a Rectangle.");
                }
                Console.WriteLine();                
            }
            object circ1 = new Circle(4);
            Circle circ2 = (Circle)circ1;

            Console.WriteLine("The {0} Area is {1:f2}", circ2.Name, circ2.Area());
            Console.ReadKey();

            Console.WriteLine("Class 11");
            //Collections: ArrayLists, Dictionaries, Queues and Stacks
            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);

            Console.WriteLine("Count: {0}", aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);

            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });
            aList.AddRange(aList2);
            aList2.Sort();
            aList2.Reverse();

            aList2.Insert(1, "Turkey");
            ArrayList range = aList2.GetRange(0, 2);

            foreach(object o in range)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("Turkey Index : {0}", aList2.IndexOf("Turkey", 0));
            string[] myArray = (string[])aList2.ToArray(typeof(string)); //arraylist to a string array

            string[] customers = { "Bob", "Sally", "Sue" };

            ArrayList cusArrayList = new ArrayList();
            cusArrayList.AddRange(customers);

            foreach(string s in cusArrayList)
            {
                Console.WriteLine(s);
            }
            //Dictionary           
            Console.ReadLine();
            Dictionary<string, string> superheroes = new Dictionary<string, string>();

            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("Barry West", "The Flash");
            superheroes.Remove("Barry West");
            Console.WriteLine("Count : {0}", superheroes.Count);
            Console.WriteLine("Clark Kent : {0}", superheroes.ContainsKey("Clark Kent"));

            superheroes.TryGetValue("Clark Kent", out string test);
            Console.WriteLine($"Clark Kent : {test}");

            foreach(KeyValuePair<string, string> item in superheroes)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
            Console.ReadLine();
            //Queue
            Queue queue = new Queue();
            queue.Enqueue(4);
            queue.Enqueue(2);
            queue.Enqueue(7);
            Console.WriteLine("1 in Queue : {0}", queue.Contains(1));
            Console.WriteLine("Remove 1st : {0}", queue.Dequeue());
            Console.WriteLine("Peek 1st : {0}", queue.Peek());

            object[] numArray = queue.ToArray();

            Console.WriteLine(string.Join(", ", numArray));

            foreach (object o in queue)
            {
                Console.WriteLine($"Queue : {o}");
            }
            Console.WriteLine();
            Console.ReadKey();

            //Stack
            Stack stack = new Stack();

            stack.Push(4);
            stack.Push(9);
            stack.Push(2);

            Console.WriteLine("Peek 1st : {0}", stack.Peek());

            Console.WriteLine("Pop 1 : {0}", stack.Pop());

            Console.WriteLine("Contains 2: {0}", stack.Contains(2));

            object[] numArray2 = stack.ToArray();

            Console.WriteLine(string.Join(", ", numArray2));

            foreach (object s in stack)
            {
                Console.WriteLine($"Stack : {s}");
            }
            Console.ReadKey();
            Console.WriteLine("Class 12");
            //Generics

            List<Bug> bugList = new List<Bug>();
            bugList.Add(new Bug() {Name = "Bitey" });
            bugList.Add(new Bug() { Name = "Snapper" });
            bugList.Add(new Bug() { Name = "Max" });

            bugList.Insert(1, new Bug() { Name = "Jensen" });
            bugList.RemoveAt(1);

            Console.WriteLine("Number of Bugs : {0}", bugList.Count);
            foreach (Bug b in bugList)
            {
                Console.WriteLine(b.Name);
            }

            int x = 5, y = 4;
            Bug.GetSum(ref x, ref y);

            string strX = "5", strY = "4";
            Bug.GetSum(ref strX, ref strY);
            Triangle<int> tri1 = new Triangle<int>(20, 10);
            Console.WriteLine("Area is : {0}", tri1.GetArea());
            Triangle<string> tri2 = new Triangle<string>("42", "10");
            Console.WriteLine("Area is : {0}", tri2.GetArea());

            //Delegates
            Arithmetic add, sub, addSub;

            add = new Arithmetic(Add);
            sub = new Arithmetic(Subtract);
            addSub = add + sub;
            sub = addSub - add;
            Console.WriteLine();
            Console.WriteLine($"Add 6 & 10");
            add(6, 10);
            Console.WriteLine($"Add & Subtract 10 & 4");
            addSub(10, 4);
            Console.WriteLine($"Add & Subtract - Add 10 & 4");
            sub(10, 4);

            Console.WriteLine("Class 13");
            //Manipulating Lists: Lambda, Where, ToList, Select, Zip, Aggregate, Average, All, Any, Distinct, Except, Intersect
            doubltIt dblIt = u => u * 2; //lambda
            Console.WriteLine($"5 * 2 = {dblIt(5)}");

            List<int> numList = new List<int> { 1, 9, 2, 6, 3 };
            var evenList = numList.Where(a => a % 2 == 0).ToList(); //where ToList

            foreach(var j in evenList)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine();

            var rangeList = numList.Where(v => (v > 2 && (v < 9)));
            foreach (var j in rangeList)
            {
                Console.WriteLine(j);
            }
            List<int> flipList = new List<int>();

            int i = 0;
            Random rnd = new Random();
            while (i < 100)
            {
                flipList.Add(rnd.Next(1, 3));
                i++;
            }
            Console.WriteLine("Heads : {0}", flipList.Where(a => a == 1).ToList().Count());
            Console.WriteLine("Tails : {0}", flipList.Where(a => a == 2).ToList().Count());
            Console.WriteLine();
            var nameList = new List<string> { "Doug", "Sally", "Sue" };
            var sNameList = nameList.Where(a => a.StartsWith("S"));
            foreach(var m in sNameList)
            {
                Console.WriteLine(m);
            }
            Console.ReadKey();
            Console.WriteLine("Select");
            var oneTo10 = new List<int>();    //Select
            oneTo10.AddRange(Enumerable.Range(1, 10));

            var squares = oneTo10.Select(b => b * b);
            foreach(var yy in squares)
            {
                Console.WriteLine(yy);
            }
            Console.ReadKey();
            Console.WriteLine("Zip");
            var listOne = new List<int>(new int[] { 1, 3, 4 }); //Zip
            var listTwo = new List<int>(new int[] { 4, 6, 8 });
            var sumList = listOne.Zip(listTwo, (xx,h) => xx + h).ToList();
            foreach (var item in sumList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine("Aggregate");
            var listThree = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 8}); //Aggregate
            Console.WriteLine("Sum: {0}", listThree.Aggregate((g,gg) => g + gg));
            Console.ReadKey();
            Console.WriteLine("Average");
            var listFour = new List<int>(new int[] { 2, 6, 7, 1, 7, 1, 2, 2 });//Average
            Console.WriteLine("Avg : {0}", listFour.AsQueryable().Average());
            Console.WriteLine("All > 3 : {0}",listFour.All(hh => hh > 3)); //All
            Console.WriteLine("Any > 3 : {0}", listFour.Any(hh => hh > 3)); //Any
            var listFive = new List<int>(new int[] { 2, 6, 7, 1, 7, 1, 2, 2 });//Distinct
            Console.WriteLine("Distinct : {0}", string.Join(", ", listFive.Distinct()));
            Console.WriteLine("Except: {0}", string.Join(", ", listThree.Except(listFive)));//Except lists the values from list listThree not in listFive
            Console.WriteLine("Intersect: {0}", string.Join(", ", listThree.Intersect(listFive)));//Intersect lists the values both in listFive and listThree



            Console.ReadKey();

        }
        static void QueryStringArray()
        {
            string[] dogs = { "K9", "Brian Griffin", "Scooby Doo", "Old Yeller", "Rin Tin Tin", "Benji", "Charlie B. Barkin", "Lassie", "Snoopy" };
            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;
            foreach(var i in dogSpaces)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
        
        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };
            var gt20 = from num in nums
                       where num > 20
                       orderby num
                       select num;
            foreach (var item in gt20)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine($"Get Type : {gt20.GetType()}");
            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();

            nums[0] = 40;
            foreach (var item in gt20)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            return arrayGT20;            
        }

        static void QueryArrayList()
        {
            ArrayList famOwners = new ArrayList()
            {
            new Owner {Name = "Sten",Owners = 2},
            new Owner {Name = "Jack",Owners = 1},
            new Owner {Name = "Trea",Owners = 5},
            };
            var famOwner = famOwners.OfType<Owner>();
            var smOwners = from owners in famOwner
                            where owners.Owners < 2
                            orderby owners.Name
                            select owners;
            foreach (var item in smOwners)
            {
                Console.WriteLine("{0} has {1} Owners", item.Name,item.Owners);
            }
        }
        public delegate void Arithmetic(double num1, double num2);

        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
        delegate double doubltIt(double val);

    }
}
