using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public interface ICollectible
     //interface that alows the player to collect and use items 
    {
        void UseItem(Player player);
    }

    public abstract class Item : ICollectible
    // this aloows the palye to collect items 

    {
        public string Name { get; set; }

        public Item(string name)
        {
            Name = name;
        }

        //for items name

        public abstract void UseItem(Player player); 
    }
    //defines how the player cna use the item 
    public class Weapon : Item
    //item difined as weappon 
    {
        public int AttackBonus { get; set; }
        //when using wepon attack bones is given 

        public Weapon(string name, int attackBonus) : base(name)
        {
            AttackBonus = attackBonus;
        }
        //for weapons name and attack bonus

        public override void UseItem(Player player)
        //item is overwritten to being a weapon
        {
            
            Console.WriteLine($"{player.Name} uses {Name}. Attack increased by {AttackBonus}!!");
            // this is how the weapon increases the players attack
        }

    }

    public class Potion : Item
    //this si another type of item insted of weapon 
    //itll increas the palyes healing when its low
    {
        public int HealthRestored { get; set; }
        //the spesific ammoubtn of health it will restore 

        public Potion(string name, int healthRestored) : base(name)
        {
            HealthRestored = healthRestored;
        }

        public override void UseItem(Player player)
        //item will be postion insted of item
        {
            Console.WriteLine($"{player.Name} uses the {Name} and regained {HealthRestored} health!!");
            player.RestoreHealth(HealthRestored);
            //restores health if players health is not to low 
        }
    }
}
