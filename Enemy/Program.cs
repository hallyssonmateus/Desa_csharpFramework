using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância de Enemy
            Enemy basicEnemy = new Enemy(100, 2.0f);
            basicEnemy.DisplayStatus();
            basicEnemy.ReceiveDamage(20);
            basicEnemy.Move();
            Console.WriteLine("Is dead? " + basicEnemy.IsDead());

            // Testando EnemyWithAttack
            EnemyWithAttack attackingEnemy = new EnemyWithAttack(100, 2.5f, 15);
            attackingEnemy.DisplayStatus();
            attackingEnemy.AttackPlayer(20);

            // Impede que o console feche imediatamente
            Console.ReadLine(); // Ou use Console.ReadKey();
        }
    }
}
