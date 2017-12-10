using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {

    // Watched Tutorials at https://www.youtube.com/channel/UCyBsvsU7uiurMiBZIYXvnyg

    public int maxHealth;

    public static int health;

    Text text;

    private LevelManager levelManager;

    public bool dead;

    // Use this for initialization
    void Start () {
        //Allows us to modify text in the inspector.
        text = GetComponent<Text>();
        //Sets Health of player each time the game starts.
        health = maxHealth;
        levelManager = FindObjectOfType<LevelManager>();
        dead = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(health <= 0 && !dead)
        {
            // If player loses all their health it kills them.
            levelManager.RespawnPlayer();
            dead = true;
        }
        text.text = "" + health;
	}
    public static void HurtPlayer(int damage)
    {
        health -= damage;
    }
    public void FullHealth()
    {
        health = maxHealth;
    }
}
