using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform cameraTransform;
    public Vector2 sensitivity;
    Vector2 direction;
    public Camera camara;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //direction += new Vector2(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X")) * sensitivity * Time.deltaTime;
        //cameraTransform.eulerAngles = direction;

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            transform.rotation = Quaternion.Euler(0f, camara.transform.rotation.eulerAngles.y, 0f);
    }
}
