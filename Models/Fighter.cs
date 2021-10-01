namespace Class_2.Models
{
    public class Fighter : ICombatant
    {
        public string Name {get;set;}

        public Armor Armor {get;set;}
        
        public Weapon Weapon {get;set;}
        
        public Fighter()
        {
            Armor = new Armor();
            Weapon = new Weapon();
            Name = "Fighter"
        }

        public void Attack(ICombatant enemy) {
            if (this.Weapon.Power > enemy.Armor.Defense) {
                System.Console.WriteLine($"{this.Name} attacks {enemy.Name} with his {this.Weapon.Name}");
            }
            else {
                System.Console.WriteLine($"{enemy.Name} blocks {name} with his {enemy.Armor.Name}");
            }

        }

        public void Defend(ICombatant) {

        }


        public interface ICombatant
        {
            void Attack(Enemy enemy);
            void Defend(Enemy enemy);
        }
        
            
        
    }
}