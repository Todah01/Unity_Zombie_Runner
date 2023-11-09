using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Switcher : MonoBehaviour
{
    [SerializeField] int currentWeapon = 0;

    void Start(){
        SetWeaponActive();
    }

    void Update(){
        int previousWeapon = currentWeapon;
        ProcessKeyInput();
        ProcessScroolWheel();

        if(previousWeapon != currentWeapon){
            SetWeaponActive();
        }
    }

    private void SetWeaponActive()
    {
        int weaponIdx = 0;
        foreach(GunWeapon weapon in GetComponent<WeaponController>().weapons){
            if(weaponIdx == currentWeapon){
                GetComponent<WeaponController>().myWeapon = weapon;
            }
            else{
                
            }
            weaponIdx++;
        }
    }

    
    private void ProcessKeyInput()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            currentWeapon = 0;
        }

        if(Input.GetKeyDown(KeyCode.Alpha2)){
            currentWeapon = 1;
        }

        if(Input.GetKeyDown(KeyCode.Alpha3)){
            currentWeapon = 2;
        }
    }

    private void ProcessScroolWheel()
    {
        if(Input.GetAxis("Mouse ScrollWheel") < 0){
            if(currentWeapon >= transform.childCount - 1){
                currentWeapon = 0;
            }
            else{
                currentWeapon++;
            }
        }

        if(Input.GetAxis("Mouse ScrollWheel") > 0){
            if(currentWeapon <= 0){
                currentWeapon = transform.childCount - 1;
            }
            else{
                currentWeapon--;
            }
        }
    }
}
