using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Select10m : MonoBehaviour
{
    [SerializeField] private Animator LlevarDiana0a10;
    public AudioSource source;
    public AudioClip Fijoseis;
    public int diez_m = 0;

    void Start()
    {
        LlevarDiana0a10 = GetComponent<Animator>();
    }

    public void Click10m()
    {
        diez_m = 10;
        this.Wait(2f, TakeDiana0a10);
    }

    void TakeDiana0a10()
    {
        LlevarDiana0a10.Play("diana0-10");
        source.PlayOneShot(Fijoseis);
    }
}
