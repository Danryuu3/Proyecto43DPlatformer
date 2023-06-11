using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boton2 : MonoBehaviour
{
    public Animator puzzle;
    public Text final;
    public int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(contador == 0)
            {
                contador = 1;
                final.gameObject.SetActive(true);
            }
            if (Input.GetMouseButton(0))
            {
                final.gameObject.SetActive(false);
                puzzle.SetTrigger("Boton");
                
            }
            
        }
    }

   
}
