using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.WeaponSpawner
{
    public class WSpawner
    {
        private _Weapon prototype;

        public WSpawner(_Weapon prototype)
        {
            this.prototype = prototype;
        }

        public _Weapon SpawnWeapon()
        {
            return prototype.Clone();
        }
    }
}
