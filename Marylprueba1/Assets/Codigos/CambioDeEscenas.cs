using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscenas : MonoBehaviour
{
    public void CargarEscena1()
    {
        SceneManager.LoadScene("Escena 1");
    }

    public void CargarEscena2()
    {
        SceneManager.LoadScene("Escena 2");
    }

    public void CargarInicio1()
    {
        SceneManager.LoadScene("Inicio 1");
    }

    public void CargarInicio2()
    {
        SceneManager.LoadScene("instructions");
    }

    public void CargarInicio3()
    {
        SceneManager.LoadScene("instructions_2");
    }

}
