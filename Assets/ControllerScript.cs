using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour {

    public float movSpeed;
    public bool died;
    public GameObject doNotColl;
	// Use this for initialization
	void Start () {
        this.movSpeed = 3f;
        this.died = false;

        Physics.IgnoreCollision(gameObject.GetComponent<Collider>(), doNotColl.GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(transform.forward * movSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-transform.right * movSpeed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(transform.right * movSpeed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(-transform.forward * movSpeed * Time.deltaTime);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag != "Terrain")
            this.died = true;
    }

}
