using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeVolume : MonoBehaviour {

    public Slider Volume;
    public AudioSource backgroundMusic;
	
	// Update is called once per frame
	void Update () {
        backgroundMusic.volume = Volume.value;
	}
}
