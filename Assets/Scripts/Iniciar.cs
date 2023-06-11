using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour
{
    public Animator anim;
    public Animator anim2;
    public GameObject luz;

    private void Start()
    {
       DontDestroyOnLoad(luz);
    }

    public void Inicia()
    {
        anim.SetTrigger("Iniciar");
        anim2.SetTrigger("Iniciar");
        StartCoroutine(EsperaIniciar());
    }

    public void Salir()
    {
        Application.Quit();
    }

    IEnumerator EsperaIniciar()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }
}
