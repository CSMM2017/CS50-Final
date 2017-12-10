using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

    // Sets camera to follow player with the option of offsetting it on the y axis.

    public PlayerController player;

    public bool following;

    public float yOff;
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();

        following = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (following)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y + yOff, transform.position.z);
        }
	}
}
