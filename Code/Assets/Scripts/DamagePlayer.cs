using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour {

    // Watched Tutorials at https://www.youtube.com/channel/UCyBsvsU7uiurMiBZIYXvnyg
    // Lowers players health whenever they run into an enemy, as well as knock them back.

    public int damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            HealthManager.HurtPlayer(damage);

            var player = other.GetComponent<PlayerController>();
            player.knockbackCount = player.knockbackTime;

            if (other.transform.position.x < transform.position.x)
                player.knockRight = true;
            else
                player.knockRight = false;
        }
    }
}
