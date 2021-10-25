using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.WeaponSpawner
{
    public class WeaponSpawnController : MonoBehaviour
    {
        private Gun gunPrototype;
        private Sword swordPrototype;
        
        private WSpawner[] weaponSpawners;


        void Start()
        {
            gunPrototype = new Gun(10, 2);
            swordPrototype = new Sword(15, 1);

            weaponSpawners = new WSpawner[] {
                new WSpawner(gunPrototype),
                new WSpawner(swordPrototype)
            };

        }


        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //If we know which spawner we are using we can easily cast to the correct monster type
                WSpawner gunSpawner = new WSpawner(gunPrototype);

                Gun newGun = gunSpawner.SpawnWeapon() as Gun;

                newGun.Talk();
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                //If we know which spawner we are using we can easily cast to the correct monster type
                WSpawner swordSpawner = new WSpawner(swordPrototype);

                Sword newSword = swordSpawner.SpawnWeapon() as Sword;

                newSword.Talk();
            }
        }
    }
}
