using UnityEngine;
using TMPro;

public class ParametrosBezierGo : MonoBehaviour
{
    [Header("Configuración del Componente:")]
    [Space]
    public string Etiqueta;
    public int DeltaGrosorInicial = 1;
    public int DeltaGrosorFinal = 5;
    [ContextMenu("Actualizar Tip")]
    private void Start()
    {
        ActualizarTip();
    }
    public void ActualizarTip()
    {
        // cambio de la etiqueta del tip
        GetComponent<TipControlador>().Contenido = Etiqueta; // este deberia eliminarse del componente
        transform.Find("Etiqueta").GetComponent<TextMeshProUGUI>().text = Etiqueta; // nueva opción

        // cambio del grosor de la linea
        GetComponent<BezierCurve>().GrosorInicial = DeltaGrosorInicial;
        GetComponent<BezierCurve>().GrosorFinal = DeltaGrosorFinal;
        GetComponent<BezierCurve>().DibujarCurva();
    }
}
