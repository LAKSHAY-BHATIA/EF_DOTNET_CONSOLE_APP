using EFPractice.Models;
using System;
using System.Linq;

namespace EFPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var db = new ActorDbContext())
            {
                if (!db.Actors.Any())
                {
                    db.Actors.AddRange(new Actor() { Name = "Salman Khan" , IsAcademyAwardWinner = false} , 
                        new Actor()
                        {
                            Name = "Akshay Kumar" , IsAcademyAwardWinner = true 
                        }
                        );
                    var count = db.SaveChanges();
                    Console.WriteLine($" Added count : {count}");

                }
                char ch = 'N';
                string ActorName;
                do
                {
                    Console.WriteLine("Please Enter the Actor NAME - ");
                    ActorName = Console.ReadLine();

                    if (ActorName != string.Empty)
                    {
                        db.Actors.Add(new Actor() { Name = ActorName });
                        db.SaveChanges();
                    }

                   
                    Console.WriteLine("(y/n)");
                    ch = (char) Console.Read();
                } while (ch == 'y');

                if (db.Actors.Any())
                {
                    foreach (var Actor in db.Actors)
                    {
                        Console.WriteLine(Actor.Name);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
