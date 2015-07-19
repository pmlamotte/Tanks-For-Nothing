using UnityEngine;
using System.Collections;

public class BulletDamage : MonoBehaviour {

	public float damage = 100f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.tag == "Player") {
			return;
		}

		if (collider.gameObject.tag == "Enemy") {
			collider.gameObject.SendMessage("ApplyDamage", damage);
		}

		Destroy(gameObject);
	}
}
