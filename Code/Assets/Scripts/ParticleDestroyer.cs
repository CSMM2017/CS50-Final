using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroyer : MonoBehaviour {

    // Watched Tutorials at https://www.youtube.com/channel/UCyBsvsU7uiurMiBZIYXvnyg
    // Deletes particles after they have played so they do not hog up memory space.

    private ParticleSystem thisOne;

	// Use this for initialization
	void Start () {
        thisOne = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
        if (thisOne.isPlaying)
            return;
        Destroy(gameObject);
	}
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
