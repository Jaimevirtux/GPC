using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Eventos10mGlock : MonoBehaviour
{
    [SerializeField] private Animator TraerDiana10a0;
    [SerializeField] private Animator LlevarDiana0a10;
    public Select10m Sel10m;
    public SimpleShoot BCount;
    public AudioSource source;
    public AudioClip Fijosiete;
    public AudioClip Fijoochodiez;
    public AudioClip Fijonueve;
    int ContMagazine = 0;
    int State10m = 0;
    public int desacato = 0;

    void Start()
    {
        TraerDiana10a0 = GetComponent<Animator>();
        LlevarDiana0a10 = GetComponent<Animator>();
    }

    public void Fogueo10m()
    {
        ContMagazine = BCount.BulletCount;
        State10m = Sel10m.diez_m;
        if (ContMagazine == 2 && State10m == 10)
        {
            this.Wait(3f, BringDiana10a0);
        }
    }
    void BringDiana10a0()
    {
        ContMagazine = BCount.BulletCount;
        if (ContMagazine >= 4)
        {
            desacato += 1;
        }
        TraerDiana10a0.Play("diana10-0");
        source.PlayOneShot(Fijosiete);
    }
    public void TakeDiana0a10()
    {
        if (ContMagazine >= 2 && State10m == 10)
        {
            LlevarDiana0a10.Play("diana0-10");
            source.PlayOneShot(Fijoochodiez);
        }
    }

    public void Comp10m()
    {
        if (desacato == 1)
        {
            ContMagazine -= 1;
        }
        if (ContMagazine == 12 && State10m == 10)
        {
            this.Wait(3f, Comp10mRevFinal);
        }
    }
    void Comp10mRevFinal()
    {
        ContMagazine = BCount.BulletCount;
        if (desacato == 1)
        {
            ContMagazine -= 1;
        }
        if (ContMagazine >= 14)
        {
            desacato += 1;
        }
        TraerDiana10a0.Play("diana10-0");
        source.PlayOneShot(Fijonueve);
        ContMagazine = 0;
        State10m = 0;
    }
}

