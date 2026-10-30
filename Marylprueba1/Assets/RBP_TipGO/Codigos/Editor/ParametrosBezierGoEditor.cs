using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ParametrosBezierGo))]
public class ParametrosBezierGoEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Mantiene el Inspector original
        DrawDefaultInspector();

        EditorGUILayout.Space(10);

        ParametrosBezierGo parametros = (ParametrosBezierGo)target; // ahora C# sabe que target es específicamente un ParametrosBezierGo

        if (GUILayout.Button("Aplicar Configuracion",GUILayout.Height(50)))
        {
            parametros.ActualizarTip();

            // Marca el objeto como modificado para que guarde los datos en la escena
            EditorUtility.SetDirty(parametros);
        }
    }
}