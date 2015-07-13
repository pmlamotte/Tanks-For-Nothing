using UnityEngine;
using System.Collections;

public class SpawnMonstersWave : WaveComponent {
	
	public Transform spawnedPrefab;
	public int numberToSpawn = 1;
	private GameObject[] spawnedEntities;

	public override void StartWave() {
		spawnedEntities = new GameObject[numberToSpawn];
		for (int i = 0; i < spawnedEntities.Length; i++) {
			spawnedEntities[i] = ((Transform)Instantiate(spawnedPrefab, this.transform.position, this.transform.rotation)).gameObject;
		}
	}

	public override bool WaveFinished() {

		for (int i = 0; i < spawnedEntities.Length; i++) {
			if (((GameObject)spawnedEntities[i]) != null) {
				return false;
			}
		}
		Debug.Log("Wave finished");
		return true;
	}
}
