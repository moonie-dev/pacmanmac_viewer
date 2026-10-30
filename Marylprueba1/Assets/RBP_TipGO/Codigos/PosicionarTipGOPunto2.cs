using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.UI;

public class PosicionarTipGOPunto2 : MonoBehaviour
{
    [Header("Gameobject - BezierGO a utilizar")]
    public GameObject TipGO;
    [ContextMenu("Posicionar Punto 2")]
    private void Start()
    {
        Posicionar();
        AsignarPuntoInicial();
    }
    public void Posicionar()
    {
        transform.Find("Punto2").position = TipGO.transform.Find("Anchor/Punto2").position;
        TipGO.GetComponent<LazyFollow>().target = transform.Find("Punto2").transform;
    }

    [ContextMenu("Asignar Punto Inicial")]
    public void AsignarPuntoInicial()
    {
        //TipGO.GetComponent<BezierCurve>().puntoInicial = transform;
        //TipGO.GetComponent<BezierCurve>().control1 = transform.Find("Control1").transform;
        TipGO.GetComponent<LineaControlador>().Punto1 = transform;
    }
}
