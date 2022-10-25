using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiempoRespuesta : MonoBehaviour
{
    public string textValue;
    public Text TiempoRespuestaText;
    public GunSelected GunSelectedChoice;
    public SimpleShoot BCount;
    public SimpleShoot BCountR;
    int ContMagazine = 0;
    int Choice = 0;
    int ContSegTotal = 0;
    float TiempoScore = 0;
    public float CountTime = 0;

    public void ChoiceGun()
    {
        Choice = GunSelectedChoice.GunSelectedTake;
    }

    void Update()
    {
        if (Choice == 6)
        {
            ContMagazine = BCountR.BulletCount;
            if (ContMagazine >= 4 && ContMagazine < 9)
            {
                ContSegTotal += 1;
                if (ContSegTotal == 60)
                {
                 ContSegTotal = 0;
                 CountTime += 1;
                }
            }
            else if (ContMagazine >= 9)
            {
                if (CountTime <= 6)
                {
                    TiempoScore = 100;
                    TiempoScorePrint();
                }
                else if (CountTime > 6)
                    {
                    TiempoScore = CountTime - 6;
                    TiempoScore *= 5;
                    TiempoScore = 100 - TiempoScore;
                    TiempoScorePrint();
                    }
            }
        }
        else if (Choice == 10)
        {
            ContMagazine = BCount.BulletCount;
            if (ContMagazine >= 4 && ContMagazine < 13)
            {
                ContSegTotal += 1;
                if (ContSegTotal == 60)
                {
                    ContSegTotal = 0; 
                    CountTime += 1;
                }
            }
            else if (ContMagazine >= 13) 
            {
                if (CountTime <= 10)
                {
                    TiempoScore = 100;
                    TiempoScorePrint();
                }
                else if (CountTime > 10)
                {
                    TiempoScore = CountTime - 10;
                    TiempoScore *= 5;
                    TiempoScore = 100 - TiempoScore;
                    TiempoScorePrint();
                }
            }
        }
        else {}
    }
    void TiempoScorePrint()
    {
        if (TiempoScore < 0)
        {
            TiempoRespuestaText.text = "--";
        }
        else
        {
            TiempoRespuestaText.text = TiempoScore.ToString();
            //print("Tiempo de Respuesta " + CountTime + " segundos");
        }
    }
}
