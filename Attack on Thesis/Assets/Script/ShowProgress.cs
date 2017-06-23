using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowProgress : MonoBehaviour {
	Progression nowstate;
	public Text EDA, EDB, EDC, EDD, EDE, EDF, EDG, EDH, EDI;
	void Start () {
		SaveLoad.Load ();
		if (nowstate.EDA == true)
			EDA.color = Color.black;
		if (nowstate.EDB == true)
			EDB.color = Color.black;
		if (nowstate.EDC == true)
			EDC.color = Color.black;
		if (nowstate.EDD == true)
			EDD.color = Color.black;
		if (nowstate.EDE == true)
			EDE.color = Color.black;
		if (nowstate.EDF == true)
			EDF.color = Color.black;
		if (nowstate.EDE == true)
			EDE.color = Color.black;
		if (nowstate.EDG == true)
			EDG.color = Color.black;
		if (nowstate.EDH == true)
			EDH.color = Color.black;
		if (nowstate.EDI == true)
			EDI.color = Color.black;
	}
}
