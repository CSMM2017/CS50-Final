using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    // Watched Tutorials at https://www.youtube.com/channel/UCyBsvsU7uiurMiBZIYXvnyg

    public GameObject currentCheckpoint;

    private PlayerController player;

    public GameObject deathParticle;
    public GameObject respawnParticle;

    public float delay;

    private CameraControls camera;

    private float playerGravity;

    public int pointsLost;

    public HealthManager health;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();

        camera = FindObjectOfType<CameraControls>();

        health = FindObjectOfType<HealthManager>();
	}
	// Update is called once per frame
	void Update () {
		
	}
    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }
    public IEnumerator RespawnPlayerCo()
    {
        //Makes player stop, go invisible, move to most recent checkpoint, then appear again with a slight delay to make it look smoother.

        Instantiate(deathParticle, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        playerGravity = player.GetComponent<Rigidbody2D>().gravityScale;
        player.GetComponent<Rigidbody2D>().gravityScale = 0f;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        camera.following = false;
        ScoreManager.AddPoints(-pointsLost);
        Debug.Log("Player Respawn");
        yield return new WaitForSeconds(delay);
        camera.following = true;
        player.GetComponent<Rigidbody2D>().gravityScale = playerGravity;
        player.transform.position = currentCheckpoint.transform.position;
        Instantiate(respawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
        health.FullHealth();
        health.dead = false;
    }
}
