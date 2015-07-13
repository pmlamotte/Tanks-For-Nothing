using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {
	
	public float secsToDestruct = 1;

	[HideInInspector]
	private float elapsedTime = 0;

	// Use this for initialization
	void Start() {

	}
	

	void FixedUpdate() {
		elapsedTime += Time.deltaTime;
		if (elapsedTime > secsToDestruct) {
			Destroy(this.gameObject);
		}
	}
}
