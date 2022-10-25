using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Desacato : MonoBehaviour
{
    public Eventos5mGlock cincomGlock;
    public Eventos10mGlock diezmGlock;
    public Eventos15mGlock quincemGlock;
    public Eventos20mGlock veintemGlock;
    public Eventos25mGlock veintycincomGlock;
    public Eventos5mRevolver cincomrevolver;
    public Eventos10mRevolver diezmrevolver;
    public Eventos15mRevolver quincemrevolver;
    int TotalDesacatoG = 0;
    int TotalDesacatoR = 0;
    int TotalDesacato = 0;
    public Text textDesacato;

    void Update()
    {
        TotalDesacatoG = cincomGlock.desacato + diezmGlock.desacato + quincemGlock.desacato + veintemGlock.desacato + veintycincomGlock.desacato;
        TotalDesacatoR = cincomrevolver.desacato + diezmrevolver.desacato + quincemrevolver.desacato;
        TotalDesacato = TotalDesacatoG + TotalDesacatoR;
        TotalDesacato *= 25;
        textDesacato.text = TotalDesacato.ToString();
    }
}
