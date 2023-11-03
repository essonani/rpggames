using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpggames
{
    internal class Player
    {
        public Player()
        {

        }
        
       public string Name { get; set; }
        public int Health { get; set; }
        public int Heal { get; set; }
        public bool IsDead { get; set; }
       
        public Player(string name, int health, int heal ,bool isdead)
        {
            Name = name;Health = health;Heal = heal;health = 100;heal = 10;IsDead = isdead; var player = "esso";
        }
        public void GetsHits(int hitvalue)
        {
           Health=Health-hitvalue;
            Console.WriteLine(Name + "have been hit with " + hitvalue + "health remainning is " + Health);
            if (Health >= 0)
            {
                Die();
            }
            void Die()
            {
                Console.WriteLine(Name + " has died");IsDead = true;
            }
        }
        public void GetsHealth(int hp)
        {
            Heal-=hp;
            Console.WriteLine(Name + "heal himself with " + hp+ "and has health of "+ Health);
        }
    }
}
