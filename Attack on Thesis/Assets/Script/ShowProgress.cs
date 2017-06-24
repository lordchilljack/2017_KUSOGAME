using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowProgress : MonoBehaviour {
	public GameMemory nowstate;
	public Text EDA, EDB, EDC, EDD, EDE, EDF, EDG, EDH, EDI;
	void Start () {
		SaveLoad.Load ();
		nowstate = SaveLoad.savedGame;
	}
	void Update()
	{
		if (nowstate.ENDINGS.EDA == true)
			EDA.color = Color.black;
		if (nowstate.ENDINGS.EDB == true)
			EDB.color = Color.black;
		if (nowstate.ENDINGS.EDC == true)
			EDC.color = Color.black;
		if (nowstate.ENDINGS.EDD == true)
			EDD.color = Color.black;
		if (nowstate.ENDINGS.EDE == true)
			EDE.color = Color.black;
		if (nowstate.ENDINGS.EDF == true)
			EDF.color = Color.black;
		if (nowstate.ENDINGS.EDE == true)
			EDE.color = Color.black;
		if (nowstate.ENDINGS.EDG == true)
			EDG.color = Color.black;
		if (nowstate.ENDINGS.EDH == true)
			EDH.color = Color.black;
		if (nowstate.ENDINGS.EDI == true)
			EDI.color = Color.black;
	}
}
