using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpggames
{
    internal class Enemy
    {
        public Enemy()
        {

        }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Heal { get; set; }
        public bool IsDead {get;set;}
        public  Enemy(string name, int health, int heal, bool isDead)
        {
            Name = name;
            Health = health;health = 50;heal = 10;
            Heal = heal;
            IsDead = isDead;
        }
        public void GetsHits(int hitValue)
        {
            Health-=hitValue;
            Console.WriteLine(Name +" has been hits with " + hitValue +" and has health of " + Health );
            if (Health >= 0)
            {
                Die();
            }
            void Die()
            {
                Console.WriteLine(Name + " has died"); IsDead = true;
            }
        }
        public void GetsHealth(int hp)
        {
            Health -= hp;
            Console.WriteLine(Name +" has heal of " + hp +" has health of "+ Health);
        }
    }
}
