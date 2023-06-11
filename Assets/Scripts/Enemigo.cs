using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform target;
    public Animator enemy;
    public  bool estoyVivo;
    public Rigidbody rb;
    public Collider iAm;
    public ContadorMan contMan;
    public int enem = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        estoyVivo = true;
        iAm = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
        navMeshAgent = GetComponent<NavMeshAgent>();
       
    }

    // Update is called once per frame
    void Update()
    {

        if (estoyVivo) 
        { 
            navMeshAgent.destination = target.position;
            rb.constraints = RigidbodyConstraints.None;
            rb.constraints = RigidbodyConstraints.None;
        }
        else
        {
            rb.constraints = RigidbodyConstraints.FreezePosition;
            rb.constraints = RigidbodyConstraints.FreezeRotation;


        }
    }

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.CompareTag("Brazo"))
        {
            enemy.SetBool("Mori", true);
            estoyVivo = false;
            iAm.enabled = !iAm.enabled;
            contMan.NumeroEnemigoAsesinados(1);
            StartCoroutine(Desaparece());
            

        }



    }

    IEnumerator Desaparece()
    {
        yield return new WaitForSeconds(1.5f);
        gameObject.SetActive(false);
    }

    
}



