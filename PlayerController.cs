using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float speed = 5.0f; // add speed
    private float turnSpeed = 25.0f; //We can turn left or right
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); //We'll move the vehicle forward
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); 
        //Make vehicle rotate instead of slide:
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput); 
    }
}
