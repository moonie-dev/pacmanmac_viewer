using UnityEngine;
using TMPro;

public class TipControlador : MonoBehaviour
{
    public string Contenido;
    //public int Ancho;
    [Space]
    [Header("Componentes:")]
    public TextMeshProUGUI Etiqueta;
    public RectTransform ControlTransformacion;

    private void Start()
    {
        ActualizarTip();
    }

    [ContextMenu("Actualizar Tip")]
    public void ActualizarTip()
    {
        Etiqueta.text = Contenido.ToString();
    }
}
