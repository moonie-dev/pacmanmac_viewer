using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
[ExecuteAlways]
public class BezierCurve : MonoBehaviour
{
    public LineRenderer line;
    public int GrosorInicial;
    public int GrosorFinal;
    [Space]
    [Header("Puntos:")]
    public Transform puntoInicial;
    public Transform puntoFinal;

    [Space]
    [Header("Controles:")]
    public Transform control1;
    public Transform control2;

    [Space]
    [Header("Resolución de la línea:")]
    [Range(10, 100)]
    public int segmentos = 50;


    void Awake()
    {
        line = GetComponent<LineRenderer>();
    }

    void Start()
    {
        DibujarCurva();
    }

    void Update()
    {
        DibujarCurva();
    }

    [ContextMenu("Dibujar Curva")]
    public void DibujarCurva()
    {
        if (puntoInicial == null || puntoFinal == null ||
            control1 == null || control2 == null)
            return;

        line.positionCount = segmentos + 1;

        for (int i = 0; i <= segmentos; i++)
        {
            float t = i / (float)segmentos;

            Vector3 punto = CalcularBezier(
                puntoInicial.position,
                control1.position,
                control2.position,
                puntoFinal.position,
                t
            );
            line.startWidth = (float)GrosorInicial/100;
            line.endWidth = (float)GrosorFinal/100;
            line.SetPosition(i, punto);
        }
    }

    Vector3 CalcularBezier(
        Vector3 p0,
        Vector3 p1,
        Vector3 p2,
        Vector3 p3,
        float t)
    {
        float u = 1 - t;

        return
            u * u * u * p0 +
            3 * u * u * t * p1 +
            3 * u * t * t * p2 +
            t * t * t * p3;
    }
}