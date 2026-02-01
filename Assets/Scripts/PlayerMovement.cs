using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] float horisontalSpeed = 6f; //Left-Right movement

    [SerializeField] public float movementSpeed = 5f; //This is for moving foward

    [SerializeField] public float speedMultiplier = 0f; //speed added when hiitng a trigger

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.linearVelocity = new Vector3(horizontalInput * horisontalSpeed, rb.linearVelocity.y, movementSpeed + speedMultiplier);
    }
   
}