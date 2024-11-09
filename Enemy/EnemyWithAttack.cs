using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemy
{
    internal class EnemyWithAttack : Enemy
    {
        // Atributo adicional
        private int attack;

        // Construtor
        public EnemyWithAttack(int initialHealth, float initialVelocity, int attackPower)
            : base(initialHealth, initialVelocity)
        {
            attack = attackPower;
        }

        // Método especial para atacar o personagem principal
        public void AttackPlayer(int damage)
        {
            Console.WriteLine($"EnemyWithAttack attacks player with {damage} damage.");
        }

        // Exibe o ataque adicional no status
        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine($"Attack Power: {attack}");
        }
    }
}
