using UnityEngine;

public class Controls : MonoBehaviour
{
    public Transform Level;
    public float Sensitivity;
    private Vector3 previousMousePos;

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - previousMousePos;
            Level.Rotate(0, -delta.x * Sensitivity, 0);
        }

        previousMousePos = Input.mousePosition;
    }
}
