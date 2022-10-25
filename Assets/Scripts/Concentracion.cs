using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Concentracion : MonoBehaviour
{
    public LayerMask InfDiana;
    private string textValue;
    private bool hasEntered;
    public Text textElement;
    public int TiempoFuera = 0;
    public int TiempoFueraFinal = 0;
    public GunSelected GunSelectedChoice;
    int Choice = 0;
    public SimpleShoot BCount;
    public SimpleShoot BCountR;
    int ContMagazine = 0;
    public TiempoRespuesta TRespuesta;
    float TRes = 0;

    public void ChoiceGunCon()
    {
        Choice = GunSelectedChoice.GunSelectedTake;
    }
    public void Update()
    {
        if (Choice == 6)
        {
            ContMagazine = BCountR.BulletCount;
            if (ContMagazine >= 4 && ContMagazine < 9)
            {
                RaycastHit RayCastDiana; //Contains raycast hit informations
                if (Physics.Raycast(transform.position, transform.forward, out RayCastDiana, 1000, InfDiana))
                {
                    if (RayCastDiana.collider.tag == "Diana")
                    {
                        TiempoFuera += 1;
                        if (TiempoFuera == 60)
                        {
                            TiempoFuera = 0;
                            TiempoFueraFinal += 1;
                        }
                    }
                }
            }
            else if (ContMagazine >= 9)
            {
                TRes = TRespuesta.CountTime;
                if (TiempoFueraFinal == TRes)
                {
                    TiempoFueraFinal = 100;
                    PrintConcentracion();
                }
                else if (TiempoFueraFinal < TRes)
                {
                    TiempoFueraFinal *= 5;
                    TiempoFueraFinal = 100 - TiempoFueraFinal;
                    PrintConcentracion();
                }
            }
        }
        if (Choice == 10)
        {
            ContMagazine = BCount.BulletCount;
            if (ContMagazine >= 4 && ContMagazine < 13)
            {
                RaycastHit RayCastDiana; //Contains raycast hit informations
                if (Physics.Raycast(transform.position, transform.forward, out RayCastDiana, 1000, InfDiana))
                {
                    if (RayCastDiana.collider.tag == "Diana")
                    {
                        TiempoFuera += 1;
                        if (TiempoFuera == 60)
                        {
                            TiempoFuera = 0;
                            TiempoFueraFinal += 1;
                        }
                    }
                }
            }
            else if (ContMagazine >= 13)
            {
                TRes = TRespuesta.CountTime;
                if (TiempoFueraFinal == TRes)
                {
                    TiempoFueraFinal = 100;
                    PrintConcentracion();
                }
                else if (TiempoFueraFinal < TRes)
                {
                    TiempoFueraFinal *= 5;
                    TiempoFueraFinal = 100 - TiempoFueraFinal;
                    PrintConcentracion();
                }
            }
        }
    }
    void PrintConcentracion()
    {
        textElement.text = TiempoFueraFinal.ToString();
    }
}
