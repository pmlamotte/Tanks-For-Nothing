using UnityEngine;
using System.Collections;

public class SpinComponent : MonoBehaviour {

	public float spinAmount = 90;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rot = this.gameObject.transform.rotation.eulerAngles;
		rot.y += spinAmount * Time.deltaTime;
		this.gameObject.transform.rotation = Quaternion.Euler(rot);
	}
}
