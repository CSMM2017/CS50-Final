using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

    // Allows us to see the end game screen when the player reaches the end.

    private bool playerInZOne;

    public string levelToLoad;

	// Use this for initialization
	void Start () {
        playerInZOne = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.W) && playerInZOne)
        {
            Application.LoadLevel(levelToLoad);
        }
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            playerInZOne = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            playerInZOne = false;
        }
    }
}
