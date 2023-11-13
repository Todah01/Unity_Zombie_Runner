using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickUp : MonoBehaviour
{
    [SerializeField] float restoreAngleAmount = 20f;
    [SerializeField] float restoreIntensityAmount = 3f;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            other.GetComponentInChildren<FlashLight>().RestoreLightAngle(restoreAngleAmount);
            other.GetComponentInChildren<FlashLight>().AddLightIntensity(restoreIntensityAmount);
            Destroy(gameObject);
        }
    }
}
