using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class GatilloIncorrecto : MonoBehaviour
{
    private InputDevice targetDevice;
    public GunSelected GunSelectedChoice;
    public LayerMask InfDiana;
    public Text textGatInc;
    int Choice = 0;
    int GatInc = 0;
    int ContSegTotal = 0;
    // Start is called before the first frame update
    public void ChoiceGunGat()
    {
        Choice = GunSelectedChoice.GunSelectedTake;
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);
        targetDevice = devices[0];
    }
    // Update is called once per frame
    void Update()
    {
        if (Choice == 6)
        {
            RaycastHit RayCastGatillo; //Contains raycast hit informations
            if (Physics.Raycast(transform.position, transform.forward, out RayCastGatillo, 1000, InfDiana))
            {
                if (RayCastGatillo.collider.tag == "Diana")
                {
                    print("Gatillo Ok!");
                }
            }
            else
            {
                targetDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool indexTouchValue);
                //Debug.Log("IndexTouch " + indexTouchValue);
                if (indexTouchValue)
                {
                    ContSegTotal += 1;
                    if (ContSegTotal == 10)
                    {
                        ContSegTotal = 0;
                        Debug.Log("Gatillo Paila " + GatInc);
                        Debug.Log("Index Touch Button touched " + indexTouchValue);
                        GatInc += 5;
                        PrintGatillo();
                    }
                }
            }
        }
        else if (Choice == 10)
        {
            RaycastHit RayCastGatillo; //Contains raycast hit informations
            if (Physics.Raycast(transform.position, transform.forward, out RayCastGatillo, 1000, InfDiana))
            {
                if (RayCastGatillo.collider.tag == "Diana")
                {
                    print("Gatillo Ok!");
                }
            }
            else
            {
                targetDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool indexTouchValue);
                //Debug.Log("IndexTouch " + indexTouchValue);
                if (indexTouchValue)
                {
                    ContSegTotal += 1;
                    if (ContSegTotal == 10)
                    {
                        ContSegTotal = 0;
                        Debug.Log("Gatillo Paila " + GatInc);
                        Debug.Log("Index Touch Button touched " + indexTouchValue);
                        GatInc += 5;
                        PrintGatillo();
                    }
                }
            }
        }
    }
    void PrintGatillo()
    {
        textGatInc.text = GatInc.ToString();
    }
}
