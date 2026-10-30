using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ParametrosTipGOCurvo))]
public class ParametrosTipGOCurvoEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EditorGUILayout.Space(10);

        ParametrosTipGOCurvo Parametros = (ParametrosTipGOCurvo)target;

        if (GUILayout.Button("Aplicar Parametros", GUILayout.Height(50)))
        {
            Parametros.AplicarParametros();
            EditorUtility.SetDirty(Parametros);
        }

    }
}