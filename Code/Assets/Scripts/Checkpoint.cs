using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    // Watched Tutorials at https://www.youtube.com/channel/UCyBsvsU7uiurMiBZIYXvnyg
    // When player runs into a checkpoint collider, it will be updated to the current checkpoint.
    public LevelManager levelManager;
    // Use this for initialization
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            levelManager.currentCheckpoint = gameObject;
            Debug.Log("Activated Checkpoint " + transform.position);
        }
    }
}
