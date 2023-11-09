using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{   
    public GunWeapon myWeapon;
    [SerializeField] GunWeapon curWeapon;
    public GunWeapon[] weapons;
    public Camera FPCamera;
    public ParticleSystem muzzleFlash;
    public GameObject hitEffect;
    public Ammo ammoSlot;
    public AmmoType ammoType;

    void Start() {
        curWeapon = myWeapon;
        myWeapon.InitSetting();
    }
    void Update(){
        if(curWeapon != myWeapon){
            curWeapon = myWeapon;
            myWeapon.InitSetting();
        }
        myWeapon.Using(ammoSlot, ammoType, muzzleFlash, FPCamera, hitEffect);
    }
}
