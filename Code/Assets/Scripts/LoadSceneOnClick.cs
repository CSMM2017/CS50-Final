using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadSceneOnClick : MonoBehaviour {

	//Function that is called when a button is pressed that loads scene based on index
	public void LoadByIndex(int sceneIndex)
	{
		SceneManager.LoadScene (sceneIndex);
	}
}
