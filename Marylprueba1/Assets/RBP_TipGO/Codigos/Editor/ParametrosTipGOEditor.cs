using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ParametrosTipGO))]
public class ParametrosTipGOEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EditorGUILayout.Space(10); // margen de 10 de separación

        ParametrosTipGO Parametros = (ParametrosTipGO)target;

        if (GUILayout.Button("Aplicar Parametros", GUILayout.Height(50)))
        {
            Parametros.AplicarParametros();
            EditorUtility.SetDirty(Parametros);
        }

    }
}