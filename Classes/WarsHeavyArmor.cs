using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR9.Classes
{
    public class WarsHeavyArmor: Wars
    {
        public double Armor { get; set; }
        public WarsHeavyArmor(double Health, double Armor) : base(Health)
        {
            this.Health = Health;
            this.Armor = Armor;
        }

        public void damage(int Damage)
        {
            double actualDamage = Damage * (1 - Armor);
            Health -= actualDamage;
        }
    }
}
