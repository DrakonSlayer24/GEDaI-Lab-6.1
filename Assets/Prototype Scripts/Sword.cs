using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.WeaponSpawner
{
    public class Sword : _Weapon
    {
        private int Damage;
        private int CCTime;

        private static int gunCounter = 0;

        public Sword(int Damage, int CCTime)
        {
            this.Damage = Damage;
            this.CCTime = CCTime;

            gunCounter += 1;
        }

        public override _Weapon Clone()
        {
            return new Sword(Damage, CCTime);
        }

        public override void Talk()
        {
            Debug.Log($"Used sword {gunCounter}. Take {Damage} damage and stunned for {CCTime} seconds");
        }
    }
}
