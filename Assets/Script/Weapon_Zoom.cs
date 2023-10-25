using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Weapon_Zoom : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomedOutSensitivity = 2f;
    [SerializeField] float zoomedInSensitivity = .5f;
    [SerializeField] RigidbodyFirstPersonController RFPcontroller;

    bool isZoom = false;
    private void OnDisable() {
        ZoomOut();
    }

    private void Update() {
        if(Input.GetMouseButtonDown(1)){
            Zoom();
        }
    }

    private void Zoom()
    {
        if(isZoom)
        {
            ZoomOut();
        }
        else
        {
            ZoomIn();
        }
    }
    private void ZoomOut()
    {
        isZoom = false;
        mainCamera.fieldOfView = zoomedOutFOV;
        RFPcontroller.mouseLook.XSensitivity = zoomedOutSensitivity;
        RFPcontroller.mouseLook.YSensitivity = zoomedOutSensitivity;
    }
    private void ZoomIn()
    {
        isZoom = true;
        mainCamera.fieldOfView = zoomedInFOV;
        RFPcontroller.mouseLook.XSensitivity = zoomedInSensitivity;
        RFPcontroller.mouseLook.YSensitivity = zoomedInSensitivity;
    }
}
