using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
    
    // Watched Tutorials at https://www.youtube.com/channel/UCyBsvsU7uiurMiBZIYXvnyg
    // Anything with this script attatched will kill the player when it runs into the objects collider.
    public LevelManager levelManager;
	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            levelManager.RespawnPlayer();
        }
    }
}
