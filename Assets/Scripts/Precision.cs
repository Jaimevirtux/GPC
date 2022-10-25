using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Precision : MonoBehaviour
{
    public string textValue;
    public Text PrecisionText;
    public CollisionBullet1 TotalCollision1;
    public CollisionBullet2 TotalCollision2;
    public CollisionBullet3 TotalCollision3;
    public CollisionBullet4 TotalCollision4;
    public CollisionBullet5 TotalCollision5;
    public GunSelected GunSelectedChoice;
    int Choice = 0;
    public SimpleShoot BCount;
    public SimpleShoot BCountR;
    int ContMagazine = 0;
    float PrecisionScore = 0;
    
    public void ChoiceGunPres()
    {
        Choice = GunSelectedChoice.GunSelectedTake;
    }

    void Update()
    {
        if (Choice == 6)
        {
            print("Revolver Selected");
            ContMagazine = BCountR.BulletCount;
            if (ContMagazine >= 4 && ContMagazine < 9)
            {
                PrecisionScore = TotalCollision1.SumaScore1 + TotalCollision2.SumaScore2 + TotalCollision3.SumaScore3 + TotalCollision4.SumaScore4 + TotalCollision5.SumaScore5;
                PrecisionScore /= 30;
                PrecisionScore *= 100;
            }
            else if (ContMagazine >= 9)
            {
                PrintPres();
            }
        }
        else if (Choice == 10)
        {
            print("Glock Selected");
            ContMagazine = BCount.BulletCount;
            if (ContMagazine >= 4 && ContMagazine < 13)
            {
                PrecisionScore = TotalCollision1.SumaScore1 + TotalCollision2.SumaScore2 + TotalCollision3.SumaScore3 + TotalCollision4.SumaScore4 + TotalCollision5.SumaScore5;
                PrecisionScore /= 50;
                PrecisionScore *= 100;
            }
            else if (ContMagazine >= 13)
            {
                PrintPres();
            }
        }
    }
    void PrintPres()
    {
        PrecisionText.text = PrecisionScore.ToString();
    }
}
