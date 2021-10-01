using System;
using Class_7.Models;

namespace Class_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create Fighter (instantiate object)
            ICombatant Fighter  = new Fighter();

            // Equip Armor (assign value)
            fighter.Armor.Defense = 10;

            // equip weapon (assign vaules)
            fighter.Weapon.Power = 10;

            //Create Enemy (instantiate object)
            Var Enemy = new Enemy();
            enemy.Armor.Defense = 8;
            enemy.Weapon.Power = 10;

            // attack enemy (execute method)
            fighter.Attack(enemy);

            IMonster monster = null;
            monster.Roar();
        }
    }
}
