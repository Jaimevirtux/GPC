using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunSelected : MonoBehaviour
{
    public int GunSelectedTake = 0;
    // Si selecciona la Glock carga la variable GunSelected con el numero 10
    public void GlockSelected()
    {
        GunSelectedTake = 10;
    }
    // Si selecciona el revolver carga la variable GunSelected con el numero 6
    public void RevolverSelected()
    {
        GunSelectedTake = 6;
    }
}
