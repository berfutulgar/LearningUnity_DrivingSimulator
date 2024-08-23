using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // add speed
    public float turnSpeed; //We can turn left or right

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //We'll move the vehicle forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
