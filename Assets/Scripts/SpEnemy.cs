using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpEnemy : MonoBehaviour
{
    private Vector3 inicioEnemy;
    private Animator anim;
    public Animator camino;
    public GameObject enemigo;
    
    // Start is called before the first frame update
    void Start()
    {
        inicioEnemy = gameObject.transform.position;
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Brazo"))
        {
            StartCoroutine(EnemySpawn());
            
        }
    }

    IEnumerator EnemySpawn()
    {
        yield return new WaitForSeconds(6f);
        gameObject.transform.position = inicioEnemy;
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        anim.SetBool("Mori", false);
    }



}
