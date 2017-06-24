using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Debug_SL : MonoBehaviour {

	public GameMemory nowstate = new GameMemory();
	public void doSave()
	{
		GameMemory.current.ENDINGS.EDA = true;
		SaveLoad.Save ();
	}
	public void doLoad(string scenename)
	{
		SceneManager.LoadScene(scenename);
	}
}
