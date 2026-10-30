using UnityEngine;

public class Billboard2 : MonoBehaviour
{
    public Camera cameraToLookAt;  // La cámara hacia la cual el objeto debe mirar

    void Update()
    {
        if (cameraToLookAt != null)
        {
            // Hacer que el objeto mire a la cámara
            Vector3 lookDirection = (cameraToLookAt.transform.position - transform.position)*-1;
            //lookDirection.y = 0;  // Para que el objeto no incline hacia arriba o hacia abajo (opcional)
            transform.rotation = Quaternion.LookRotation(lookDirection);
        }
    }
}
