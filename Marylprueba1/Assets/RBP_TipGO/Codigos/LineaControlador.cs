using UnityEngine;

[ExecuteAlways]
public class LineaControlador : MonoBehaviour
{
    public LineRenderer Linea;
    public int GrosorInicial;
    public int GrosorFinal;
    [Space]
    [Header("Puntos de la Línea")]
    [Space]
    [Header("Punto Inicial")]
    public Transform Punto1;
    [Header("Punto Final")]
    public Transform Punto2;

    private void Update()
    {
        Ajustar();
    }

    [ContextMenu("Ajustar Línea")]
    public void Ajustar()
    {
        Linea.SetPosition(0, Punto1 != null ? Punto1.transform.position : new Vector3(0f,0f,0f));
        Linea.SetPosition(1, Punto2.transform.position);
        Linea.startWidth = (float)GrosorInicial/100;
        Linea.endWidth = (float)GrosorFinal /100;
    }

}
