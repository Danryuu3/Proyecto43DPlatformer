using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Camera camara;
    public CharacterController3D player;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) && player.mePuedoMover)
            transform.rotation = Quaternion.Euler(0f, camara.transform.rotation.eulerAngles.y, 0f);
    }
}
