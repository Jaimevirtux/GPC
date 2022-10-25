using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Eventos5mRevolver : MonoBehaviour
{
    [SerializeField] private Animator TraerDiana5a0;
    [SerializeField] private Animator LlevarDiana0a5;
    public Select5m Sel5m;
    public SimpleShoot BCount;
    public AudioSource source;
    public AudioClip Fijosiete;
    public AudioClip Fijoochoseis;
    public AudioClip Fijonueve;
    int ContMagazine = 0;
    int State5m = 0;
    public int desacato = 0;

    void Start()
    {
        TraerDiana5a0 = GetComponent<Animator>();
        LlevarDiana0a5 = GetComponent<Animator>();
    }

    public void Fogueo5mR()
    {
        ContMagazine = BCount.BulletCount;
        State5m = Sel5m.cinco_m;
        if (ContMagazine == 2 && State5m == 5)
        {
            this.Wait(3f, BringDiana5a0);
        }
    }
    void BringDiana5a0()
    {
        ContMagazine = BCount.BulletCount;
        if (ContMagazine >= 4)
        {
            desacato += 1;
        }
        TraerDiana5a0.Play("diana5-0");
        source.PlayOneShot(Fijosiete);
    }
    public void TakeDiana0a5()
    {
        ContMagazine = BCount.BulletCount;
        if (ContMagazine >= 2 && State5m == 5)
        {
            LlevarDiana0a5.Play("diana0-5");
            source.PlayOneShot(Fijoochoseis);
        }
    }

    public void Comp5mR()
    {
        if (desacato == 1)
        {
            ContMagazine -= 1;
        }
        if (ContMagazine == 8 && State5m == 5)
        {
            this.Wait(3f, Comp5mRevFinal);
        }
    }
    void Comp5mRevFinal()
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
        TraerDiana5a0.Play("diana5-0");
        source.PlayOneShot(Fijonueve);
        ContMagazine = 0;
        State5m = 0;
    }
}
