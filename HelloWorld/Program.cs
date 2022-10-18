using System;
namespace HelloWorld
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is Awesome!");
            Console.WriteLine(4 + 175);
            

            /*hello mister hobbit,
             How are you today? */
            
            
            const string name = "Trentness Everdeen";
            

            Console.WriteLine("Hello " + name); 
             

            string Greeting;
            Greeting = ("Howdy");
            Console.WriteLine(Greeting);

            int myNum = 36;
            double myDoubleNum = 5.99D;
            const char myLetter = 'T';
            string myText = "Starting Something New";
            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myText);

            string firstName = "Trentness";
            string lastName = "Everdeen";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 57;
            int y = 69;
            int z = 112;
            Console.WriteLine(x + y * z);

            Console.WriteLine("Enter User name:");
            string userName = Console.ReadLine();   
            Console.WriteLine("User name is: " + userName);

            Console.WriteLine("Enter your age:");
            int age =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            int t = 37;
            t++;
            Console.WriteLine(t);

            string txt = "Mississippi";
            Console.WriteLine("The length of the text string is: " + txt.Length);
            Console.WriteLine(txt.ToUpper());

            Console.WriteLine("Enter hero name: ");
            string hero = Console.ReadLine();
            Console.WriteLine("Enter villian name: ");
            string villian = Console.ReadLine();
            string battle = $"{hero} vs. {villian}";    
            
           Console.WriteLine(battle);

            bool theHeroisVenom = true;
            bool robinIsLame = true;
            bool cottageCheeseIsDelicious = false;
            Console.WriteLine(theHeroisVenom && robinIsLame);
            Console.WriteLine(cottageCheeseIsDelicious);
            
       }
    }
}