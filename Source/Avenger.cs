using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTest
{
    public class Avenger
    {
        Random rd = new Random();
        private string Name;
        private int Strength;
        private int Health;
        private int Agility;
        private bool HaveWeapon;
        public int PocetMrtvychZab;

        public Avenger(string Name, int Strength, int Health, int Agility, bool HaveWeapon)
        {
            this.Name = Name;
            this.Strength = Strength;
            this.Health = Health;
            this.Agility = Agility;
            this.HaveWeapon = HaveWeapon;
            if (HaveWeapon == true)
            {
                int AttackOfWeapon = rd.Next(1, 15);
                string NameOfWeapon = "Sword of destruction";
                Weapon weapon = new Weapon(NameOfWeapon, AttackOfWeapon);
            }
        }

        public void Attack(Smallfrog frog)
        {
            
            frog.Health = frog.Health - Strength;
            if(frog.Health <= 0)
            {
                Console.WriteLine("Žába zemřela.");
                PocetMrtvychZab++;
            }
        }

        public void Defend()
        {
            Console.WriteLine("Nejlepší útok je obrana!");
            Strength = Strength + 1;
        }

        public void Run()
        {
            Console.WriteLine("Pardon...");
            HaveWeapon = false;
        }

        public void Greetings()
        {
            Console.WriteLine("Měj se. Zabil jsem " + PocetMrtvychZab + " žab."); 
        }

        public class Smallfrog
        {
            private string Name;
            public int Health;
            public Smallfrog(string Name, int Health)
            {
                this.Name = Name;
                this.Health = Health;
            }
        }
        public class Weapon
        {
            private string Name;
            private int Attack;
            public Weapon(string Name, int Attack)
            {
                this.Name = Name;
                this.Attack = Attack;
            }

        }

    }
    
}
