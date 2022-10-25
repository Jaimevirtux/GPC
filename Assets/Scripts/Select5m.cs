using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Select5m : MonoBehaviour
{
    [SerializeField] private Animator LlevarDiana0a5;
    public AudioSource source;
    public AudioClip Fijoseis;
    public int cinco_m = 0;

    void Start()
    {
        LlevarDiana0a5 = GetComponent<Animator>();
    }

    public void Click5m()
    {
        cinco_m = 5;
        this.Wait(2f, TakeDiana0a5);
    }

    void TakeDiana0a5()
    {
        LlevarDiana0a5.Play("diana0-5");
        source.PlayOneShot(Fijoseis);
    }
}
