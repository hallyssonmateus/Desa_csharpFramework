using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemy
{
    internal class FlyingEnemy : Enemy
    {
        // Atributo adicional
        private int altitude;

        // Construtor
        public FlyingEnemy(int initialHealth, float initialVelocity, int initialAltitude)
            : base(initialHealth, initialVelocity)
        {
            altitude = initialAltitude;
        }

        // Método especial para simular o voo
        public void Fly()
        {
            Console.WriteLine($"FlyingEnemy is flying at altitude {altitude}.");
        }

        // Exibe o voo no status
        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine($"Altitude: {altitude}");
        }
    }
}
