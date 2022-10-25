using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magazine : MonoBehaviour
{
    public GunSelected GunSelectedChoice;
    int Choice = 0;
    public int numberOfBullet = 0;

    public void ChoiceGunMag()
    {
        Choice = GunSelectedChoice.GunSelectedTake;
        if (Choice == 6)
        {
            numberOfBullet = 6;
        }
        else if (Choice == 10)
        {
            numberOfBullet = 10;
        }
    }
}
