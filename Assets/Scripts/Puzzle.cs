using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public Animator puzzle;

    // Start is called before the first frame update
     void Start()
    {
        
    }

   // private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Brazo"))
    //    {
    //        llave = player.getLlave();
    //        player.setLlaves(1);
    //        print(llave);
    //    }
    //}


    private void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player") && Input.GetMouseButton(0))
        {
                puzzle.SetBool("P4", true);
        }
    }
}
