using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Select25m : MonoBehaviour
{
    [SerializeField] private Animator LlevarDiana0a25;
    public AudioSource source;
    public AudioClip Fijoseis;
    public int veintycinco_m = 0;

    void Start()
    {
        LlevarDiana0a25 = GetComponent<Animator>();
    }

    public void Click25m()
    {
        veintycinco_m = 25;
        this.Wait(2f, TakeDiana0a25);
    }

    void TakeDiana0a25()
    {
        LlevarDiana0a25.Play("diana0-25");
        source.PlayOneShot(Fijoseis);
    }
}
