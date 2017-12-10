using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour {
    
    // Watched Tutorials at https://www.youtube.com/channel/UCyBsvsU7uiurMiBZIYXvnyg

    public int pointsToAdd;

    // Adds points to score and destroys coins after collected
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.GetComponent<PlayerController>() == null)
            return;
        ScoreManager.AddPoints(pointsToAdd);

        Destroy(gameObject);
    }
}
