using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7); 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() //We switched from Update to LateUpdate to move the camera after the vehicle has moved.
    {
        // offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
