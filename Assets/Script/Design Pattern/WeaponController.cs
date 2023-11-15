using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeaponController : MonoBehaviour
{   
    public GunWeapon myWeapon;
    public GunWeapon[] weapons;
    public Camera FPCamera;
    public ParticleSystem muzzleFlash;
    public GameObject hitEffect;
    public Ammo ammoSlot;
    public TextMeshProUGUI ammoText;

    GunWeapon curWeapon;

    void Start() {
        curWeapon = myWeapon;
        myWeapon.InitSetting();
    }
    void Update(){
        DisplayAmmo();
        if(curWeapon != myWeapon){
            curWeapon = myWeapon;
            myWeapon.InitSetting();
        }
        WeaponZoomSetting();
        myWeapon.Using(ammoSlot, myWeapon.data.ammoType, muzzleFlash, FPCamera, hitEffect);
    }

    private void DisplayAmmo()
    {
        int currentAmmo = ammoSlot.GetCurrentAmmo(myWeapon.data.ammoType);
        ammoText.text = currentAmmo.ToString();
    }

    private void WeaponZoomSetting()
    {
        if(myWeapon.data.zoom == true){
            GetComponent<Weapon_Zoom>().enabled = true;
        }
        else{
            GetComponent<Weapon_Zoom>().enabled = false;
        }
    }
}
