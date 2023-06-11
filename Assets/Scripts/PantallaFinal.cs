using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PantallaFinal : MonoBehaviour
{
    public Animator anim;
    public Animator anim2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void botonYes()
    {
        anim.SetTrigger("YES");
        anim2.SetTrigger("Avanza");
        StartCoroutine(EsperaReiniciar());
    }

    public void botonNo()
    {
        anim.SetTrigger("NO");
        StartCoroutine(EsperaTerminar());
    }

    IEnumerator EsperaReiniciar()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(1);
    }

    IEnumerator EsperaTerminar()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);
    }
}
