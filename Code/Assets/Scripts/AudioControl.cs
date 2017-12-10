using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour {

	//A function that is attached to the music toggle button that is mutes/unmutes audio when clicked
	public void MuteOnClick() 
	{
		AudioListener.pause = !AudioListener.pause;
	}
}
