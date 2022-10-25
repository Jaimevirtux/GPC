using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class BulletHoles : MonoBehaviour
{
    public LayerMask Diana;
    [SerializeField] private GameObject hitgraphic;
    public GameObject HoleParent;
    public GunSelected GunSelectedChoice;
    int Choice = 0;
    public SimpleShoot BCount;
    public SimpleShoot BCountR;
    int ContMagazine = 0;
    // Start is called before the first frame update
    public void CreateBulletHole()
    {
        Choice = GunSelectedChoice.GunSelectedTake;
        if (Choice == 6)
        {
            ContMagazine = BCountR.BulletCount;
            if (ContMagazine < 9)
            {
                RaycastHit hitInfo; //Contains raycast hit informations
                if (Physics.Raycast(transform.position, transform.forward, out hitInfo))
                {//Returns true if the ray touches something
                    GameObject hitmarket = Instantiate(hitgraphic, hitInfo.point + hitInfo.normal, Quaternion.identity);
                    hitmarket.transform.LookAt(hitInfo.point + hitInfo.normal);
                    hitmarket.transform.position += hitmarket.transform.forward;
                    //Changing the bullet hole's position a bit so it will fit better
                    hitmarket.transform.parent = HoleParent.transform;
                }
            }
        }
        else if (Choice == 10)
        {
            ContMagazine = BCount.BulletCount;
            if (ContMagazine < 13)
            {
                RaycastHit hitInfo; //Contains raycast hit informations
                if (Physics.Raycast(transform.position, transform.forward, out hitInfo))
                {//Returns true if the ray touches something
                    GameObject hitmarket = Instantiate(hitgraphic, hitInfo.point + hitInfo.normal, Quaternion.identity);
                    hitmarket.transform.LookAt(hitInfo.point + hitInfo.normal);
                    hitmarket.transform.position += hitmarket.transform.forward;
                    //Changing the bullet hole's position a bit so it will fit better
                    hitmarket.transform.parent = HoleParent.transform;
                }
            }
        }
    }
}
