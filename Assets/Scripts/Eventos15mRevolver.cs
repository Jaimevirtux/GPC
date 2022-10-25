using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Eventos15mRevolver : MonoBehaviour
{
    [SerializeField] private Animator TraerDiana15a0;
    [SerializeField] private Animator LlevarDiana0a15;
    public Select15m Sel15m;
    public SimpleShoot BCount;
    public AudioSource source;
    public AudioClip Fijosiete;
    public AudioClip Fijoochoseis;
    public AudioClip Fijonueve;
    int ContMagazine = 0;
    int State15m = 0;
    public int desacato = 0;

    void Start()
    {
        TraerDiana15a0 = GetComponent<Animator>();
        LlevarDiana0a15 = GetComponent<Animator>();
    }

    public void Fogueo15mR()
    {
        ContMagazine = BCount.BulletCount;
        State15m = Sel15m.quince_m;
        if (ContMagazine == 2 && State15m == 15)
        {
            this.Wait(3f, BringDiana15a0);
        }
    }
    void BringDiana15a0()
    {
        ContMagazine = BCount.BulletCount;
        if (ContMagazine >= 4)
        {
            desacato += 1;
        }
        TraerDiana15a0.Play("diana15-0");
        source.PlayOneShot(Fijosiete);
    }
    public void TakeDiana0a15()
    {
        if (ContMagazine >= 2 && State15m == 15)
        {
            LlevarDiana0a15.Play("diana0-15");
            source.PlayOneShot(Fijoochoseis);
        }
    }

    public void Comp15mR()
    {
        if (desacato == 1)
        {
            ContMagazine -= 1;
        }
        if (ContMagazine == 8 && State15m == 15)
        {
            this.Wait(3f, Comp15mRevFinal);
        }
    }
    void Comp15mRevFinal()
    {
        ContMagazine = BCount.BulletCount;
        if (desacato == 1)
        {
            ContMagazine -= 1;
        }
        if (ContMagazine >= 10)
        {
            desacato += 1;
        }
        TraerDiana15a0.Play("diana15-0");
        source.PlayOneShot(Fijonueve);
        ContMagazine = 0;
        State15m = 0;
    }
}
