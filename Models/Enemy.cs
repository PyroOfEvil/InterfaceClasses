namespace Class_2.Models
{
    public class Enemy : ICombatant
    {
        public string Name {get;set;}
        public Armor Armor {get;set;}
        public Weapon Weapon {get;set;}
        
        public void Attack(Enemy enemy) 
        {
            throw new System.NotImpletmentedException();
        }

        public void Defend(Enemy enemy) 
        {
            throw new System.NotImpletmentedException();
        }

        public Enemy()
        {
            Name = "enemy"
            armor = new armor
            weapon = new weapon
        }

        
    }
}
    
