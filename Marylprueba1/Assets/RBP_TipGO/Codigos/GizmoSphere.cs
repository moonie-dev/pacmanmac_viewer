using UnityEngine;

public class GizmoSphere : MonoBehaviour
{
    public Color Color = Color.green;
    [Range(0.07f,0.2f)]
    public float Radio = 0.05f;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color;
        Gizmos.DrawSphere(transform.position, Radio);
    }
}
