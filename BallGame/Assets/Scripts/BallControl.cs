using UnityEngine;

public class BallControl : MonoBehaviour {

    public Rigidbody ballRB;

    public float rotationSpeed = 100f;
    public float jumpHeight = 8;
    private bool isFalling = false;
    private float distToGround;

    private void Start()
    {
        // Getting the distance from the center to the ground.
        distToGround = GetComponent<Collider>().bounds.extents.y;    
    }

    void FixedUpdate () {
        float rotation = rotationSpeed;

        rotation *= Time.deltaTime;

        if (isFalling == false) {
            if (Input.GetKey("w"))
            {
                ballRB.AddForce(Vector3.forward * rotation);
            }
            if (Input.GetKey("s"))
            {
                ballRB.AddForce(Vector3.back * rotation);
            }
            if (Input.GetKey("a"))
            {
                ballRB.AddForce(Vector3.left * rotation);
            }
            if (Input.GetKey("d"))
            {
                ballRB.AddForce(Vector3.right * rotation);
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            isFalling = true;
            ballRB.AddForce(0, jumpHeight, 0, ForceMode.VelocityChange);
        }
    }

    // Check if we are in the ground. Return true if we are else return null.
    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
    }

    void OnCollisionEnter()
    {
        if (isFalling == true)
            FindObjectOfType<AudioManager>().Play("BallHit");
        isFalling = false;
    }
}
