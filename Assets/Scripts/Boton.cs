using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public Animator anim;
    int numero;
    

    private void Start()
    {
        numero = Random.Range(0, 3);
       
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetMouseButton(0))
        {
            
            anim.SetTrigger("InicioP");
            switch (numero)
            {
                case 0:
                    anim.SetBool("P1", true);
                    break;
                case 1:
                    anim.SetBool("P2", true);
                    break;
                case 2:
                    anim.SetBool("P1", true);
                    break;
                default:
                    anim.SetBool("P1", true);
                    break;
            }
           
        }
    }

    

     
}
