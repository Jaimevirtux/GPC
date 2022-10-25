using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionBullet5 : MonoBehaviour
{
    public string textValue;
    public Text textElement;
    int Score = 0;
    public int SumaScore5 = 0;
    public SimpleShoot BCount;
    public SimpleShoot BCountR;
    public GunSelected GunSel;
    int GunSelect = 0;
    int ContMagazine = 0;
    void OnTriggerEnter(Collider other)
    {
        GunSelect = GunSel.GunSelectedTake;
        if (GunSelect == 10)
        {
            ContMagazine = BCount.BulletCount;
        }
        if (GunSelect == 6)
        {
            ContMagazine = BCountR.BulletCount;
        }
        if (other.gameObject.tag == "Bullet")
        {
            print("5");
            Score = 5;
            textElement.text = Score.ToString();
        }
        if (other.gameObject.tag == "Bullet" && ContMagazine >= 4)
        {
            SumaScore5 += 5;
        }
    }
}