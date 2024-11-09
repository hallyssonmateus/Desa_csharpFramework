using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemy
{
    internal class JumpingEnemy : Enemy
    {
        // Atributo adicional
        private int altitude;

        // Construtor
        public JumpingEnemy(int initialHealth, float initialVelocity, int initialAltitude)
            : base(initialHealth, initialVelocity)
        {
            altitude = initialAltitude;
        }

        // Método especial para simular o salto
        public void Jump()
        {
            Console.WriteLine($"JumpingEnemy jumps to altitude {altitude}.");
        }

        // Exibe o salto no status
        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine($"Jump Altitude: {altitude}");
        }
    }
}
