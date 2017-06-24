using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {
	public GameMemory nowstate;
	public void ChangeScene(string scenename)
    {
		SaveLoad.Load ();
		nowstate = SaveLoad.savedGame;
		SaveLoad.savedGame = nowstate;
		SaveLoad.Save ();
		SceneManager.LoadScene(scenename);
    }
	public void exitgame()
	{
		Application.Quit ();	
	}

}
