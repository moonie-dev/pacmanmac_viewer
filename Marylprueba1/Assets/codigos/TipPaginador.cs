using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipPaginador : MonoBehaviour
{
    public GameObject[] ArregloTips;
    public int Pagina = 0;

    private void Start()
    {
        ReiniciarPaginador(Pagina);
    }

    public void ReiniciarPaginador(int que_pagina)
    {
        for (int i = 0; i < ArregloTips.Length; i++)
        {
            ArregloTips[i].SetActive(false);
        }

        ArregloTips[que_pagina].SetActive(true);
    }
}
