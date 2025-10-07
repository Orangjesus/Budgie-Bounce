using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    private float rotX = 0;
    private float rotY = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotX = rotX + Input.GetAxis("Mouse X");
        rotY = rotY + Input.GetAxis("Mouse Y");

        transform.rotation = Quaternion.Euler(-rotY, rotX, 0f);

    }
}
