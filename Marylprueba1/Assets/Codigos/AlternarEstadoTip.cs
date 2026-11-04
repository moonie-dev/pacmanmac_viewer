using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternarEstadoTip : MonoBehaviour
{
    public GameObject[] Estados;

    private void Start()
    {
        Estados[0].SetActive(true);
        Estados[1].SetActive(false);
    }

    public void alternar()
    {
        Estados[0].SetActive(!Estados[0].activeSelf);
        Estados[1].SetActive(!Estados[0].activeSelf);
    }
}
