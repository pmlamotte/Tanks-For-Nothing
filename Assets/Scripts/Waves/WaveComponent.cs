using UnityEngine;
using System.Collections;

public abstract class WaveComponent : MonoBehaviour {

	[SerializeField]
	public int wave = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public abstract void StartWave();

	public abstract bool WaveFinished();
}
