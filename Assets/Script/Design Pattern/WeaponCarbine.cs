using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCarbine : GunWeapon
{
    public override void InitSetting()
    {
        data.range = 100f;
        data.damage = 30f;
        data.timeBetweenShots = 0.5f;
        data.zoom = true;
        data.ammoType = AmmoType.Bullets;
    }

    public override void Using(Ammo ammoSlot, AmmoType ammoType, ParticleSystem muzzleFlash, Camera FPCamera, GameObject hitEffect)
    {
        base.Using(ammoSlot, ammoType, muzzleFlash, FPCamera, hitEffect);
    }
}
