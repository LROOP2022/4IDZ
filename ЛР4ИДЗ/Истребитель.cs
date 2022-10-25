using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Истребитель : Авиасредство
    {
        protected int weaponCount;
        public Истребитель(string pName, int pPrice, int pMaxHeight, int pWeaponCount) : base(pName, pPrice, pMaxHeight)
        {
            weaponCount = pWeaponCount;
        }

        override public string GetName()
        {
            return name + " Количество оружия: " + weaponCount.ToString();
        }
    }
}
