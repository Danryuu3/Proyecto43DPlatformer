using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnPlayer : MonoBehaviour 
{ 

    private Vector3 inicioPlayer;
    private Animator anim;
    public CharacterController3D player;
    int vidas = 3;
    public Collider personaje;
    Rigidbody rb;
    public RawImage image;
    public RenderTexture textura2;
    public RenderTexture textura1;


    // Start is called before the first frame update
    void Start()
    {
        inicioPlayer = gameObject.transform.position;
        anim = gameObject.GetComponent<Animator>();
        player = gameObject.GetComponent<CharacterController3D>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        print(vidas);

        if (vidas == 0)
        {
            StartCoroutine(GameOver());
        }

        switch (vidas)
        {
            case 2:
                image.texture = textura2;
                break;
            case 1:
                image.texture = textura1;
                break;
            case 0:
                image.gameObject.SetActive(false);
                break;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            vidas -= 1;
            StartCoroutine(PlayerSpawn());
        }
        if (collision.gameObject.CompareTag("Ground") && player.muerteCaida >= 2f)
        {
            vidas -= 1;
            StartCoroutine(PlayerSpawn());
           
           
        }
    }

    IEnumerator PlayerSpawn()
    {
        yield return new WaitForSeconds(1.5f);
        gameObject.transform.position = inicioPlayer;
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        anim.SetBool("Muerto", false);
        anim.SetBool("Walk", false);
        player.mePuedoMover = true;
        personaje.enabled = true;
        rb.isKinematic = false;


    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(2);
    }

    
}
