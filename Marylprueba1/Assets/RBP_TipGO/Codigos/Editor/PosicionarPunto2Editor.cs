using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PosicionarPunto2))]
public class PosicionarPunto2Editor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EditorGUILayout.Space(10);

        PosicionarPunto2 Parametros = (PosicionarPunto2)target; // ahora C# sabe que target es específicamente un ParametrosBezierGo

        if (GUILayout.Button("Ajustar Punto 2", GUILayout.Height(50)))
        {
            Parametros.Posicionar();
            Parametros.AsignarPuntoInicial();
            EditorUtility.SetDirty(Parametros);
        }
    }
}
