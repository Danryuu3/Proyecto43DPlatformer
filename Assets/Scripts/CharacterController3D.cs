using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController3D : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    bool jump;
    int llaves = 0;
    public bool mePuedoMover = true;
    bool IsJump = false;
    public float muerteCaida;
    public LayerMask ground; 
    public GameObject mesh;
    public GameObject camaraRoot;
    public Animator player;
    public Collider personaje;
    
    
    Vector2 inputValues;
    Vector3 velocity;
    Rigidbody rb;
    

    // Start is called before the first frame update
    void Start()
    {
        ground = LayerMask.GetMask("Ground");
        rb = GetComponent<Rigidbody>();
        player = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mePuedoMover) 
        { 
            inputValues = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;


            if (inputValues.magnitude != 0) 
            {
                float angleDirection = Mathf.Atan2(inputValues.x, inputValues.y) * Mathf.Rad2Deg + camaraRoot.transform.eulerAngles.y;
                mesh.transform.localRotation = Quaternion.Euler(0, angleDirection,0) ;
                player.SetBool("Walk", true); 
            }
            else
            {
                player.SetBool("Walk", false);
            }

            if (IsJump && Input.GetButtonDown("Jump"))
            {
                jump = true;
                player.SetTrigger("Jump");
                IsJump = false;

            }

            if (Input.GetMouseButtonDown(0))
            {
                player.SetTrigger("Pega");
                
            }

            if (!IsJump && rb.velocity.y != 0)
            {
                muerteCaida += Time.deltaTime; 
            }
            else if (IsJump)
            {
                if (muerteCaida >= 2f)
                {
                    player.SetBool("Muerto", true);
                    mePuedoMover = false;
                    muerteCaida = 0f;
                    personaje.enabled = false;
                    rb.isKinematic = true;
                }
                else
                {
                    muerteCaida = 0f;
                }

            }
        }
       


    }

    private void FixedUpdate()
    {
        if (mePuedoMover) 
        { 
            velocity.x = inputValues.x; 
            velocity.z = inputValues.y;


            velocity = Quaternion.Euler(0, camaraRoot.transform.eulerAngles.y, 0) * velocity;
            if (jump)
            {
                velocity.y = JumpSpeed();
                jump = false;
            }
            else
                velocity.y = rb.velocity.y;
            rb.velocity = velocity;
        }
        else
            player.SetBool("Muerto", false);


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Esyoy pisando ");
            IsJump = true;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            player.SetBool("Muerto", true);
            mePuedoMover = false;
            personaje.enabled = false;
            rb.isKinematic = true;

        }

        



    }

  




    bool IsGrounded()
    {
        return Physics.Raycast(this.transform.position, Vector3.down, out RaycastHit hit, 1.2f, ground);
    }

    float JumpSpeed()
    {
        return Mathf.Sqrt(jumpHeight * 2 * -Physics.gravity.y);
    }

    public void setLlaves(int num)
    {
        llaves += num;
    }

    public int getLlave()
    {
        return llaves;
    }
}