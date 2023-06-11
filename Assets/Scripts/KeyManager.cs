using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyManager : MonoBehaviour
{

    public Animator[] anim;
    public Animator boton;
    public GameObject[] llaves;
    public Text inicio;
    public Text final;
    public int contador = 0;
    
    public int llave = 0;
    //public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(QuitarInicio());
    }

    // Update is called once per frame
    void Update()
    {
        if (llaves[0].transform.localScale == Vector3.zero)
        {
            anim[0].SetTrigger("Rec");
            llaves[0].SetActive(false); 
            llave += 1;
            print("Tengo " + llave + " Llaves");
            
        }
        if (llaves[1].transform.localScale == Vector3.zero)
        {
            anim[1].SetTrigger("Rec");
            llaves[1].SetActive(false);
            llave += 1;
            print("Tengo " + llave + " Llaves");
        }
        if (llaves[2].transform.localScale == Vector3.zero)
        {
            anim[2].SetTrigger("Rec");
            llaves[2].SetActive(false);
            llave += 1;
            print("Tengo " + llave + " Llaves");
        }
        if (llaves[3].transform.localScale == Vector3.zero)
        {
            anim[3].SetTrigger("Rec");
            llaves[3].SetActive(false);
            llave += 1;
            print("Tengo " + llave + " Llaves");
        }
        if (llaves[4].transform.localScale == Vector3.zero)
        {
            anim[4].SetTrigger("Rec");
            llaves[4].SetActive(false);
            llave += 1;
            print("Tengo " + llave + " Llaves");
        }
        if (llaves[5].transform.localScale == Vector3.zero)
        {
            anim[5].SetTrigger("Rec");
            llaves[5].SetActive(false);
            llave += 1;
            print("Tengo " + llave + " Llaves");
        }
        if (llaves[6].transform.localScale == Vector3.zero)
        {
            anim[6].SetTrigger("Rec");
            llaves[6].SetActive(false);
            llave += 1;
            print("Tengo " + llave + " Llaves");
        }

        if (llave == 7)
        {
            boton.SetTrigger("Completado");
            if(contador == 0)
            {
                contador = 1;
                final.gameObject.SetActive(true);
                StartCoroutine(QuitaMensaje());
            }
        }
        
    }

    IEnumerator QuitaMensaje()
    {
        yield return new WaitForSeconds(4f);
        final.gameObject.SetActive(false);
    }

    IEnumerator QuitarInicio()
    {
        yield return new WaitForSeconds(3f);
        inicio.gameObject.SetActive(false);
    }



    public int getLlave()
    {
        return llave;
    }
}
