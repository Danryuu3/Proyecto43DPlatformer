using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNoDamage : MonoBehaviour
{
    public Transform targetTransform;
    public Rigidbody rb;
    public Collider iAm;
    public NavMeshAgent navMeshAgent;
    public Animator navegar;
    public Animator enemy;

    private bool estoyVivo;



    // Start is called before the first frame update
    void Start()
    {
        iAm = GetComponent<Collider>();
        enemy = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        navegar = navegar.gameObject.GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();

        estoyVivo = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (estoyVivo)
            navMeshAgent.destination = targetTransform.position;
        else
        {
            rb.constraints = RigidbodyConstraints.FreezePosition;
            rb.constraints = RigidbodyConstraints.FreezeRotation;


        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Object"))
        {
            navegar.SetTrigger("meMuevo");

        }

        if (other.gameObject.CompareTag("Brazo"))
        {


            enemy.SetBool("Mori", true);
            estoyVivo = false;
            iAm.enabled = !iAm.enabled;

        }



    }
}

   
