using System;
using abstração_rpg.entities;
namespace Program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args,)
        {
            Hero Arus= new Hero("Arus", 23, "knight");
            Wizard Jenica= new Wizard("Jenica", 23, "white wizard");
            
            Console.WriteLine(Arus.Attack());
            
           
        }
    }
}