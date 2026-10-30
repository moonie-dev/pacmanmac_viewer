using UnityEngine;

public class LineBetweenObjects : MonoBehaviour
{
    public GameObject objectA;
    public GameObject objectB;

    private LineRenderer line;

    void Start()
    {
        line = GetComponent<LineRenderer>();

        line.positionCount = 2;
    }

    void Update()
    {
        line.SetPosition(0, objectA.transform.position);
        line.SetPosition(1, objectB.transform.position);
    }
}
