using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponP90 : GunWeapon
{
    public override void InitSetting()
    {
        data.range = 60f;
        data.damage = 15f;
        data.timeBetweenShots = 0.2f;
        data.zoom = false;
        data.ammoType = AmmoType.Bullets;
    }

    public override void Using(Ammo ammoSlot, AmmoType ammoType, ParticleSystem muzzleFlash, Camera FPCamera, GameObject hitEffect)
    {
        base.Using(ammoSlot, ammoType, muzzleFlash, FPCamera, hitEffect);
    }
}
