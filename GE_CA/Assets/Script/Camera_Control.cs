using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    public Transform Player;

    private float mouseX, mouseY; // Get the value of mouse movement

    public float mouseSensitivity; // Get mouse sensitivity

    public float xRotation;

    private void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation,-70f,70f);

        Player.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(xRotation,0,0);

    }
}
