using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipPaginador : MonoBehaviour
{
    public GameObject[] ArregloTips;
    public int Pagina = 0;

    private void Start()
    {
        MostrarPagina(Pagina);
    }

    public void MostrarPagina(int que_pagina)
    {
        for (int i = 0; i < ArregloTips.Length; i++)
        {
            ArregloTips[i].SetActive(false);
        }

        ArregloTips[que_pagina].SetActive(true);
    }

    public int PaginaSiguiente()
    {
        Pagina++;

        if (Pagina > (ArregloTips.Length - 1))
        {
            Pagina = 0;
        }

        return Pagina;
    }

    public int PaginaAnterior()
    {
        Pagina--;

        if (Pagina < 0)
        {
            Pagina = ArregloTips.Length - 1;
        }

        return Pagina;
    }

    public void SiguienteTip()
    {
        MostrarPagina(PaginaSiguiente());
    }

    public void AnteriorTip()
    {
        MostrarPagina(PaginaAnterior());
    }
}
