using UnityEngine;
using System.Collections;

public class CharacterAttributes : MonoBehaviour {

	public float health = 100.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ApplyDamage(float damage) {
		health -= damage;
		Debug.Log(health);
		if (health <= 0) {
			SendMessage("OnDeath");
		}
	}
}
