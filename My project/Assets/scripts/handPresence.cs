using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class handPresence : MonoBehaviour
{
    private GameObject baculo;
    
    
    private rayoMago algo;
    private InputDevice targetDevice;
    public InputDeviceCharacteristics controllerCharacteristics;
    // Start is called before the first frame update
    void Start()
    {
        baculo = GameObject.Find("BACULO");
        algo = (rayoMago)baculo.GetComponent(typeof(rayoMago));
    
        List<InputDevice> devices =  new List<InputDevice>();
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
    
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);

        foreach(var item in devices){

            Debug.Log(item.name + item.characteristics);
        }

        if(devices.Count > 0){

            targetDevice = devices[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue);
        if(primaryButtonValue){
            Debug.Log("Pressing primary button");
            
        }

        targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);
        if(triggerValue > 0.1f){

            Debug.Log("Trigger Pressed");
            algo.Fire();
        }

        targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue);
        if(primary2DAxisValue != Vector2.zero){
            Debug.Log("Primary touchpad " + primary2DAxisValue);
        }
        
    }
}
