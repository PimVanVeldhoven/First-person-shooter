using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    
    private float currentSpeed;
    public float walkingSpeed = 10f;
    public float runningSpeed = 20f;

    public float gravity = -0.5f;
    public float jumpSpeed = 0.8f;
    private float baseLineGravity;

    private float moveX;
    private float moveZ;
    private Vector3 move;


    public CharacterController characterController;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentSpeed = walkingSpeed;
        baseLineGravity = gravity;
    }

    // Update is called once per frame
    void Update()
    {
        ///Debug.Log(characterController.isGrounded);
        moveX = Input.GetAxis("Horizontal")*currentSpeed* Time.deltaTime;
        moveZ = Input.GetAxis("Vertical")*currentSpeed* Time.deltaTime;

        move = transform.right*moveX+
               transform.up*gravity+
               transform.forward*moveZ;

        characterController.Move(move);

       if( Input.GetKey(KeyCode.LeftShift)){
            currentSpeed = runningSpeed;
        }
        else
        {
            currentSpeed = walkingSpeed;
        }

       if(characterController.isGrounded==true && Input.GetButtonDown("Jump"))
        {
            //rb.AddForce(Vector3.up * 1000, ForceMode.Impulse);
            Debug.Log("jgyfjgf");
            gravity = baseLineGravity;
            gravity *= -jumpSpeed;
        }
       if(gravity > baseLineGravity)
        {
            gravity -= 2*Time.deltaTime;
        }
    }
}
