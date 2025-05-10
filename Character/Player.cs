using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class Monster : IDamageable
    //monster takes damage 
    {
        public string Name { get; private set; }
        //monsters name , alows for scalability as well
        //for diffrent levels cna have diffrent names 

        public int Health { get; private set; }
        //monstor health

        public Monster(string name, int health)
        {
            Name = name;
            Health = health;
        }
        //initializes new mosntor 

        public void TakeDamage(int damage)
        //allows for the monster to take damage 
        {
            Health -= damage;
            Console.WriteLine($"{Name} takes {damage} damage!");
            //cheaks if monstore sitill ahs health or is defeted 
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} has been slain!!!!");
            }
        }
        

        public void Attack(Player player)
        //alternativly the mosnter cna attack the player 
        {
            int damage = 10; 
            // the damage amount
            Console.WriteLine($"{Name} attacks {player.Name} for {damage} damage!!!");
            player.TakeDamage(damage);
            // the players damage 
        }
    }

    public interface IDamageable
    {
        void TakeDamage(int damage);
    }
}
