using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 2;

	// Use this for initialization
	void Start () {
		Rigidbody rigidBody = GetComponent<Rigidbody>();
		rigidBody.velocity = this.gameObject.transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
