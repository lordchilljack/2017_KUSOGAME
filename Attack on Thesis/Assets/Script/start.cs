using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {
	public GameMemory nowstate;
	public void ChangeScene(string scenename)
    {
		SceneManager.LoadScene(scenename);
    }
	public void exitgame()
	{
		Application.Quit ();	
	}

}
