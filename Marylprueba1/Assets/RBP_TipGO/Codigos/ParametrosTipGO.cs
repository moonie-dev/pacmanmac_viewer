using UnityEditor;
using UnityEngine;

public class ParametrosTipGO : MonoBehaviour
{
    [Header("Configuración del Componente:")]
    [Space]
    public string Etiqueta;
    public int DeltaGrosorInicial = 1;
    public int DeltaGrosorFinal = 5;
    public void AplicarParametros()
    {
        GetComponent<TipControlador>().Contenido = Etiqueta;
        GetComponent<TipControlador>().ActualizarTip();
        GetComponent<LineaControlador>().GrosorInicial = DeltaGrosorInicial;
        GetComponent<LineaControlador>().GrosorFinal = DeltaGrosorFinal;
    }
}