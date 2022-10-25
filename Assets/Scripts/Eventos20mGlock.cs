using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Eventos20mGlock : MonoBehaviour
{
    [SerializeField] private Animator TraerDiana20a0;
    [SerializeField] private Animator LlevarDiana0a20;
    public Select20m Sel20m;
    public SimpleShoot BCount;
    public AudioSource source;
    public AudioClip Fijosiete;
    public AudioClip Fijoochodiez;
    public AudioClip Fijonueve;
    int ContMagazine = 0;
    int State20m = 0;
    public int desacato = 0;

    void Start()
    {
        TraerDiana20a0 = GetComponent<Animator>();
        LlevarDiana0a20 = GetComponent<Animator>();
    }

    public void Fogueo20m()
    {
        ContMagazine = BCount.BulletCount;
        State20m = Sel20m.veinte_m;
        if (ContMagazine == 2 && State20m == 20)
        {
            this.Wait(3f, BringDiana20a0);
        }
    }
    void BringDiana20a0()
    {
        ContMagazine = BCount.BulletCount;
        if (ContMagazine >= 4)
        {
            desacato += 1;
        }
        TraerDiana20a0.Play("diana20-0");
        source.PlayOneShot(Fijosiete);
    }
    public void TakeDiana0a20()
    {
        if (ContMagazine >= 2 && State20m == 20)
        {
            LlevarDiana0a20.Play("diana0-20");
            source.PlayOneShot(Fijoochodiez);
        }
    }

    public void Comp20m()
    {
        if (desacato == 1)
        {
            ContMagazine -= 1;
        }
        if (ContMagazine == 12 && State20m == 20)
        {
            this.Wait(3f, Comp20mRevFinal);
        }
    }
    void Comp20mRevFinal()
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
        TraerDiana20a0.Play("diana20-0");
        source.PlayOneShot(Fijonueve);
        ContMagazine = 0;
        State20m = 0;
    }
}
