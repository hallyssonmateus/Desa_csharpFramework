using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemy
{
    internal class Enemy
    {
        // Atributos básicos
        protected int health;
        protected float velocity;

        // Construtor
        public Enemy(int initialHealth, float initialVelocity)
        {
            health = initialHealth;
            velocity = initialVelocity;
        }

        // Método para reduzir a saúde do inimigo
        public void ReceiveDamage(int damage)
        {
            health -= damage;
            Console.WriteLine($"Enemy received {damage} damage. Health is now {health}.");
        }

        // Método para exibir o status do inimigo
        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Enemy Status - Health: {health}, Velocity: {velocity}");
        }

        // Método para movimentação 
        public virtual void Move()
        {
            Console.WriteLine("Enemy is moving with velocity " + velocity);
        }

        // Verifica se o inimigo está morto
        public bool IsDead()
        {
            return health <= 0;
        }
    }
}
