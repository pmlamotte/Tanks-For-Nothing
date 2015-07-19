using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Plane plane = new Plane(this.gameObject.transform.up, this.gameObject.transform.position);
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		float distance = -1;
		plane.Raycast(ray, out distance); // intersect with our plane
		Vector3 pos = ray.GetPoint(distance); // grab the intersection point
		Vector3 dir = pos - this.gameObject.transform.position;
		dir.y = 0;

		Quaternion newRot = Quaternion.LookRotation(dir);
		this.gameObject.transform.rotation = newRot;
	}
}
