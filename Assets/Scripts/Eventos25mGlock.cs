using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Eventos25mGlock : MonoBehaviour
{
    [SerializeField] private Animator TraerDiana25a0;
    [SerializeField] private Animator LlevarDiana0a25;
    public Select25m Sel25m;
    public SimpleShoot BCount;
    public AudioSource source;
    public AudioClip Fijosiete;
    public AudioClip Fijoochodiez;
    public AudioClip Fijonueve;
    int ContMagazine = 0;
    int State25m = 0;
    public int desacato = 0;

    void Start()
    {
        TraerDiana25a0 = GetComponent<Animator>();
        LlevarDiana0a25 = GetComponent<Animator>();
    }

    public void Fogueo25m()
    {
        ContMagazine = BCount.BulletCount;
        State25m = Sel25m.veintycinco_m;
        if (ContMagazine == 2 && State25m == 25)
        {
            this.Wait(3f, BringDiana25a0);
        }
    }
    void BringDiana25a0()
    {
        ContMagazine = BCount.BulletCount;
        if (ContMagazine >= 4)
        {
            desacato += 1;
        }
        TraerDiana25a0.Play("diana25-0");
        source.PlayOneShot(Fijosiete);
    }
    public void TakeDiana0a25()
    {
        if (ContMagazine >= 2 && State25m == 25)
        {
            LlevarDiana0a25.Play("diana0-25");
            source.PlayOneShot(Fijoochodiez);
        }
    }

    public void Comp25m()
    {
        if (desacato == 1)
        {
            ContMagazine -= 1;
        }
        if (ContMagazine == 12 && State25m == 25)
        {
            this.Wait(3f, Comp25mRevFinal);
        }
    }
    void Comp25mRevFinal()
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
        TraerDiana25a0.Play("diana25-0");
        source.PlayOneShot(Fijonueve);
        ContMagazine = 0;
        State25m = 0;
    }
}

