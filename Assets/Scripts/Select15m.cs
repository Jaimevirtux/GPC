using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Select15m : MonoBehaviour
{
    [SerializeField] private Animator LlevarDiana0a15;
    public AudioSource source;
    public AudioClip Fijoseis;
    public int quince_m = 0;

    void Start()
    {
        LlevarDiana0a15 = GetComponent<Animator>();
    }

    public void Click15m()
    {
        quince_m = 15;
        this.Wait(2f, TakeDiana0a15);
    }

    void TakeDiana0a15()
    {
        LlevarDiana0a15.Play("diana0-15");
        source.PlayOneShot(Fijoseis);
    }
}
