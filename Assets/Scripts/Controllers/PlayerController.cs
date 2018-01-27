using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float moveSpeed = 5f;
    public float rotationSpeed = 1f;

    //just temporary till i get something better working
    [Header("camera")]
    public GameObject mainCamera;
    public Vector3 cameraPosition;

    private Rigidbody2D playerRB;

	// Use this for initialization
	void Start () {
        playerRB = GetComponent<Rigidbody2D>();
        mainCamera = GameObject.Find("Main Camera");

	}
	
	// Update is called once per frame
	void Update ()
    {
        
        movePlayer();
        cameraPosition = new Vector3(this.transform.position.x, this.transform.position.y, -10f);
        mainCamera.transform.position = cameraPosition;

    }

    private void movePlayer()
    {

        //move forwards
        if (Input.GetKey("w"))
        {
            playerRB.velocity = transform.up * moveSpeed;
        }

        //move backwards
        //not in use for this demo
        /*
        if (Input.GetKey("s"))
        {
            playerRB.velocity = transform.up * -moveSpeed;

        }*/

        //Rotate left
        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.forward * rotationSpeed);
        }

        //Rotate right
        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.forward * -rotationSpeed);
        }
    }
}
