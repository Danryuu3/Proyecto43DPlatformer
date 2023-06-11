using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpe : MonoBehaviour
{
    public Animator brazo;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            brazo.SetTrigger("Pega");
        }
    }
}
