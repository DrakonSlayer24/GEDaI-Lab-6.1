using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.WeaponSpawner
{
    public class Gun : _Weapon
    {
        private int Damage;
        private int CCTime;

        private static int gunCounter = 0;

        public Gun(int Damage, int CCTime)
        {
            this.Damage = Damage;
            this.CCTime = CCTime;

            gunCounter += 1;
        }

        public override _Weapon Clone()
        {
            return new Gun(Damage, CCTime);
        }

        public override void Talk()
        {
            Debug.Log($"Used gun {gunCounter}. Take {Damage} damage and stunned for {CCTime} seconds");
        }
    }
}
