using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");

		CharacterController body = GetComponent<CharacterController>();

		body.SimpleMove(new Vector3(x * speed, 0 , y * speed));
	}
}
