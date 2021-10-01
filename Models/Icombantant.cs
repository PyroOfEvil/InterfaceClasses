namespace Class_2.Models
{
    public class ICombatant
    {
        public string Name {get; set;}
        public Armor Armor {get; set;}
        public Weapon Weapon {get;set;}
        void Attack(Icombatant enemy);
        void Defend(ICombatant enemy);
        public int Health {get; set;}
        void health(Icombatant Enemy);
        public int Level{get; set;}
        void Level(Icombatant Enemy);


        
        
    }
}