using UnityEngine;
using System.Collections;

public class ObjectMover : MonoBehaviour {

    Rigidbody rb;

	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 500, 0);
	}
	
}
