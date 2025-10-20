using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR9.Classes
{
    public class Wars
    {
        public double Health {  get; set; }
        public Wars (double Health)
        {
            this.Health = Health;
        }

        public virtual void damage(double Damage)
        {
            Health -= Damage;
        }
    }
}
