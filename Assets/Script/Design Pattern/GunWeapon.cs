using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Data{
    public float range;
    public float damage;
    public float timeBetweenShots;
    public bool zoom;
    public AmmoType ammoType;
}

public abstract class GunWeapon : MonoBehaviour
{
    public Data data;
    bool canShoot = true;
    public abstract void InitSetting();

    void OnEnable() {
        canShoot = true;
    }
    public virtual void Using(Ammo ammoSlot, AmmoType ammoType, ParticleSystem muzzleFlash, Camera FPCamera, GameObject hitEffect){
        if(Input.GetMouseButtonDown(0) && canShoot){
            StartCoroutine(Shoot(ammoSlot, ammoType, muzzleFlash, FPCamera, hitEffect));
        }
    }

    IEnumerator Shoot(Ammo ammoSlot, AmmoType ammoType, ParticleSystem muzzleFlash, Camera FPCamera, GameObject hitEffect)
    {
        canShoot = false;
        if(ammoSlot.GetCurrentAmmo(ammoType) > 0)
        {
            PlayMuzzleFlash(muzzleFlash);
            ProcessRaycast(FPCamera, hitEffect);
            ammoSlot.ReduceCurrentAmmo(ammoType);
        }

        yield return new WaitForSeconds(data.timeBetweenShots);
        canShoot = true;
    }

    private void PlayMuzzleFlash(ParticleSystem muzzleFlash)
    {
        muzzleFlash.Play();
    }

    private void ProcessRaycast(Camera FPCamera, GameObject hitEffect)
    {
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, data.range))
        {
            CreateHitImpact(hit, hitEffect);
            Enemy_Health target = hit.transform.GetComponent<Enemy_Health>();
            if (target == null) return;
            target.TakeDamage(data.damage);
        }
        else
        {

            return;
        }
    }

    private void CreateHitImpact(RaycastHit hit, GameObject hitEffect)
    {
        GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact, 0.1f);
    }
}
