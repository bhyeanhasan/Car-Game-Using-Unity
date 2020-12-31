using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carControll : MonoBehaviour
{

    public Rigidbody rb;
    int force = 50;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("New Game Started");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            rb.AddForce(0,0, force * Time.deltaTime,ForceMode.VelocityChange); 
        }
        if(Input.GetKey("s"))
        {
            rb.AddForce(0,0,-(force * Time.deltaTime),ForceMode.VelocityChange); 
        }
        if(Input.GetKey("d"))
        {
            rb.AddForce(force * Time.deltaTime,0,0,ForceMode.VelocityChange); 
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-(force * Time.deltaTime),0,0,ForceMode.VelocityChange); 
        }

        if(rb.position.y < -1)
        {
            FindObjectOfType<gameMenu>().EndGame();
        }

        if (Input.GetKey("e"))
            transform.Rotate(Vector3.up * 100 * Time.deltaTime);
      
        if (Input.GetKey("q"))
            transform.Rotate(-Vector3.up * 100 * Time.deltaTime);
    }
}
