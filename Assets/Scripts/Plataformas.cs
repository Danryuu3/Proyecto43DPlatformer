using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas : MonoBehaviour
{
    public Animator plataforma;
    // Start is called before the first frame update
    void Start()
    {
        plataforma = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            plataforma.SetTrigger("Plataforma1");
        }
    }
}
