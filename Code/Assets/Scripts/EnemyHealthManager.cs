using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    // Unused but would have kept track of the enemies health and killed it when the player jumped on its head, reducing its health to 0

    public int enemyHealth;

    public GameObject deathParticle;

    public int points;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (enemyHealth <= 0)
        {
            Instantiate(deathParticle, transform.position, transform.rotation);
            ScoreManager.AddPoints(points);
            Destroy(gameObject);
        }   
	}

    public void giveDamage(int damageGiven)
    {
        enemyHealth -= damageGiven;
    }
}
