using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Debug_SL : MonoBehaviour {

	public GameMemory nowstate = new GameMemory();
	public void doSave()
	{
		nowstate.ENDINGS.EDA = true;
		SaveLoad.savedGame.ENDINGS.EDA = nowstate.ENDINGS.EDA;
		SaveLoad.Save ();
	}
	public void doLoad(string scenename)
	{
		SceneManager.LoadScene(scenename);
	}
}
