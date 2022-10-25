using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Select20m : MonoBehaviour
{
    [SerializeField] private Animator LlevarDiana0a20;
    public AudioSource source;
    public AudioClip Fijoseis;
    public int veinte_m = 0;

    void Start()
    {
        LlevarDiana0a20 = GetComponent<Animator>();
    }

    public void Click20m()
    {
        veinte_m = 20;
        this.Wait(2f, TakeDiana0a20);
    }

    void TakeDiana0a20()
    {
        LlevarDiana0a20.Play("diana0-20");
        source.PlayOneShot(Fijoseis);
    }
}
