using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aparecer : MonoBehaviour
{
    public GameObject[] objetos;
    public Vector3[] posInicial;
    public Collider[] colliders;
    public Animator[] anim;
    public ContadorMan c;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= objetos.Length - 1; i++)
        {
            posInicial[i] = objetos[i].gameObject.transform.position;
            colliders[i] = objetos[i].gameObject.GetComponent<Collider>();
            anim[i].SetBool("Vivo", true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (c.numEnemigos == 5)
        {
            StartCoroutine(Aparezcan());
            //for (int i = 0; i <= objetos.Length - 1; i++)
             //   anim[i].SetBool("Vivo", true);
            c.ReinciaEnemigos();
        }
    }

    IEnumerator Aparezcan()
    {
        yield return new WaitForSeconds(5f);
        for (int i = 0; i <= objetos.Length - 1; i++)
        {
            anim[i].SetBool("Vivo", false);
            objetos[i].gameObject.SetActive(true);
            objetos[i].gameObject.transform.position = posInicial[i];
            colliders[i].enabled = true;
            objetos[i].gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            objetos[i].gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            objetos[i].gameObject.GetComponent<Enemigo>().estoyVivo = true;
            anim[i].SetBool("Vivo", true);

        }
    }
}
