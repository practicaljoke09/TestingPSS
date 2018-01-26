using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    //Variables
   [HideInInspector] public float horizontalAxis;
   [HideInInspector] public float verticalAxis;
    public string player;
    public float moveSpeed;

    private Vector3 movementDirection;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        horizontalAxis = Input.GetAxis("Horizontal" + player);
        verticalAxis = Input.GetAxis("Vertical" + player);
        CharacterMovement();


	}

    public void CharacterMovement()
    {
        if (horizontalAxis != 0)
        {
            if(horizontalAxis > 0)
            {
                movementDirection = Vector3.right;

                transform.position += Vector3.right * moveSpeed;

                transform.rotation = Quaternion.LookRotation(Vector3.right);
            }

            if (horizontalAxis < 0)
            {
                movementDirection = Vector3.left;

                transform.position += Vector3.left * moveSpeed;

                transform.rotation = Quaternion.LookRotation(Vector3.left);
            }


        }
    }
}

