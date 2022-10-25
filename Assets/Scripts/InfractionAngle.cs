using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class InfractionAngle : MonoBehaviour
{
    public LayerMask InfAngle;
    private string textValue;
    private bool hasEntered;
    public Text textElement;
    public int TotalInfractionAngle = 0;
    public int TotalInfractionAngleFinal = 0;
    void Update()
    {
        RaycastHit RayCastAngle; //Contains raycast hit informations
        if(Physics.Raycast(transform.position, transform.forward, out RayCastAngle, 1000, InfAngle))
        {
            if (RayCastAngle.collider.tag == "AngleInfraction")
            {
                TotalInfractionAngle += 1;
                if (TotalInfractionAngle == 60)
                {
                    TotalInfractionAngle = 0;
                    TotalInfractionAngleFinal += 5;
                    textElement.text = TotalInfractionAngleFinal.ToString();
                }
                else { }
            }
        }
    }
}
