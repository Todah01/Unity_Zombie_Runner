using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShotgun : GunWeapon
{
    public override void InitSetting()
    {
        data.range = 50f;
        data.damage = 60f;
        data.timeBetweenShots = 2f;
        data.zoom = false;
    }

    public override void Using(Ammo ammoSlot, AmmoType ammoType, ParticleSystem muzzleFlash, Camera FPCamera, GameObject hitEffect)
    {
        base.Using(ammoSlot, ammoType, muzzleFlash, FPCamera, hitEffect);
    }
}
