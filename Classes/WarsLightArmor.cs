using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR9.Classes
{
    internal class WarsLightArmor : Wars
    {
        public double Armor { get; set; }
        public WarsLightArmor(double Health, double Armor): base(Health)
        {
            this.Health = Health;
            this.Armor = Armor;
        }

        public override void damage(double Damage)
        {
            double actualDamage = Damage * (1 - Armor);
            Health -= actualDamage;
        }
    }
}
