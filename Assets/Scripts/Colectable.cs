using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colectable : MonoBehaviour
{
    public Animator llave;
    
    // Start is called before the first frame update
    void Start()
    {
        //llave = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            llave.SetTrigger("Recogio");
        }
    }

}
