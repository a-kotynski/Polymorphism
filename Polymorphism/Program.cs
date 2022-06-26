using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* https://www.youtube.com/watch?v=qE7a0XQ2SH8
 * Polymorphism
 * Means "many different forms"
 * Objects can be treated as their base classes without any fuss
 * Derived classes can override "virtual" methods defined in ther parents
 * 
 */
namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            ElderDragon dragon = new ElderDragon();
            dragon.Attack();
            Console.ReadKey();
        }
    }
    public class Enemy
    {
        protected string Name; //encapsulation is about keyword private
        protected int Damage;
        public virtual void Attack() //virtual keyword means that this method
                                     //can be overwritten
        {
            Console.WriteLine($"{Name} attacks, dealing {Damage} damage!");
        }
    }
    public class ElderDragon : Enemy
    {
        public ElderDragon()
        {
            Name = "Elder Dragon";
            Damage = 25;
        }
        public override void Attack() // this method overrides parent method in
                                      // the class Enemy
        {
            base.Attack(); //base refers to parent method in parent class 
            Console.WriteLine("Elder Dragon is pretty sweet. He attacks you" +
                "and kills you! :D");
        }
    }
}