using System;
using abstração_rpg.entities;
namespace Program // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args){

            Hero Arus = new Hero("Arus", 23, "knight");
           Wizard wizard = new Wizard("Jenica",23,"wizard");
            
            
            Console.WriteLine(Arus.Attack());
            Console.WriteLine(wizard.Attack());
            
           
        }
    }
}
           