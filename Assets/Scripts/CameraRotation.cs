using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public int speed;
    public Transform cameraAxisTransform;
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + Time.deltaTime * speed
            * Input.GetAxis("Mouse X"), 0);
        cameraAxisTransform.transform.localEulerAngles = new Vector3(cameraAxisTransform.transform.localEulerAngles.x 
                                                                     + Time.deltaTime * speed 
                                                                     * Input.GetAxis("Mouse Y"), 0, 0);
    }
}
