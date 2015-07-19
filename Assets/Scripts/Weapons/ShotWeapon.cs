using UnityEngine;
using System.Collections;

public class ShotWeapon : MonoBehaviour {

	[Tooltip("The time between when the weapon can fire, in seconds")]
	public float fireRate = 2;
	[Tooltip("How far away the bullet should be from the game object when first created")]
	public float bulletOffset = 1;
	public Transform bulletPrefab;

	private float lastFired;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		bool tryToFire = Input.GetMouseButton(0);
		if (tryToFire && Time.time - lastFired - fireRate > 0) {
			// Can fire again, fire the weapon
			Vector3 bulletPos = this.gameObject.transform.position + (this.gameObject.transform.forward.normalized * bulletOffset);
			Instantiate(bulletPrefab, bulletPos, this.gameObject.transform.rotation);
			lastFired = Time.time;
		}
	}
}
