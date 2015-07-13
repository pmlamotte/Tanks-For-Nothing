using UnityEngine;
using System;
using System.Collections;

public class WaveManager : MonoBehaviour {

	[SerializeField]
	public int startingWave = 0;
	private int currentWaveIdx = 0;
	private WaveComponent currentWave;
	private WaveComponent[] waveComponents;

	// Use this for initialization
	void Start () {
		currentWaveIdx = startingWave;
		waveComponents = GameObject.FindObjectsOfType<WaveComponent>();
		Array.Sort(waveComponents, (WaveComponent u1, WaveComponent u2) => u1.wave - u2.wave);
	}
	
	// Update is called once per frame
	void Update () {
		if (currentWaveIdx >= waveComponents.Length) {
			return;
		}
		if (currentWave == null) {
			currentWave = waveComponents[currentWaveIdx];
			currentWave.StartWave();
		}

		if (currentWave.WaveFinished()) {
			currentWaveIdx++;
			currentWave = null;
		}
	}
}
