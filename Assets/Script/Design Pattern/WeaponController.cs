using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{   
    public GunWeapon myWeapon;
    public Camera FPCamera;
    public ParticleSystem muzzleFlash;
    public GameObject hitEffect;
    public Ammo ammoSlot;
    public AmmoType ammoType;

    void Start() {
        myWeapon.InitSetting();
    }
    void Update(){
        myWeapon.Using(ammoSlot, ammoType, muzzleFlash, FPCamera, hitEffect);
    }
}
