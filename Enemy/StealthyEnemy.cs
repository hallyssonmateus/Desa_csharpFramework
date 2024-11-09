using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemy
{
    internal class StealthyEnemy : Enemy
    {
        // Construtor
        public StealthyEnemy(int initialHealth, float initialVelocity)
            : base(initialHealth, initialVelocity)
        {
        }

        // Método especial para ficar invisível
        public void Invisible()
        {
            Console.WriteLine("StealthyEnemy is now invisible.");
        }

        // Exibe o status, indicando que o inimigo pode ficar invisível
        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("Stealth Ability: Can become invisible.");
        }
    }
}
