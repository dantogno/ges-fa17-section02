using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	// Use this for initialization
	void Start ()
    {
        //Debug.Log("Called from Start.");  

        // This code "teleports" my game object to a new position
        //transform.position = new Vector3(3,0,0);

	}
	
	// Update is called once per frame
	void Update () {
        float horizontalInput = Input.GetAxis("Horizontal");

        Debug.Log("horizontal input: " + horizontalInput);

        float speed = 0.2f;

        transform.Translate(speed * horizontalInput, 0, 0);

  


        if (Input.GetButtonDown("Jump"))
        {
            transform.Translate(0, 6, 0);
        }

    }
}
