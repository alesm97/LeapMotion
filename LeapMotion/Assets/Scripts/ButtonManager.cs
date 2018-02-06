using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

    // Referencia al componente AudioSource
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        // Recuperamos la referencia al componente AudioSource
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void click()
    {
        audioSource.Play();
    }

}
