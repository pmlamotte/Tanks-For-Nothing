using UnityEngine;
using System.Collections;

public class DestroyOnDeath : MonoBehaviour {

	public void OnDeath() {
		Destroy(this.gameObject);
	}
}
