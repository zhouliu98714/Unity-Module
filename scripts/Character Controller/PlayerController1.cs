using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// At this point, this code is not compeletely done. 
// The player is not contraint to the ground (when moving with key controls)
// Jumping works, however, not contraint to the ground as well.

// The good thing is, we can fly in our bookstore!!! :)

public class PlayerController1 : MonoBehaviour
{


    public float speed = 5;
    private Rigidbody rb;
    public LayerMask groundLayers;

    public float jumpForce = 7; // applying mathematical calculation to jump
    public SphereCollider col;
    // Use this for initialization

    #region Monobehaviour API
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);


        // if we press the space
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    // use this function to make sure that we don't jump infinitely -- once we hits the ground, we stop.
    private bool IsGrounded(){
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, 
         col.bounds.center.z), col.radius * .9f, groundLayers);
    }
    #endregion
}
