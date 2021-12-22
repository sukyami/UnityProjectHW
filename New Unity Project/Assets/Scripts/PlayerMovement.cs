
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float speedForce = 1000f; 

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, (forwardForce+ speedForce) * Time.deltaTime);
        }
        if (Input.GetKey("x"))
        {
            rb.AddForce(0, 0, (forwardForce - speedForce) * Time.deltaTime);
        }



    }
}
