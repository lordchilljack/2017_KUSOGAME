using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowProgress : MonoBehaviour {
	public Text EDA, EDB, EDC, EDD, EDE, EDF, EDG, EDH, EDI;
	void Start () {
		SaveLoad.Load ();

	}
	void Update()
	{
		if (GameMemory.current.ENDINGS.EDA == true)
			EDA.color = Color.black;
		if (GameMemory.current.ENDINGS.EDB == true)
			EDB.color = Color.black;
		if (GameMemory.current.ENDINGS.EDC == true)
			EDC.color = Color.black;
		if (GameMemory.current.ENDINGS.EDD == true)
			EDD.color = Color.black;
		if (GameMemory.current.ENDINGS.EDE == true)
			EDE.color = Color.black;
		if (GameMemory.current.ENDINGS.EDF == true)
			EDF.color = Color.black;
		if (GameMemory.current.ENDINGS.EDE == true)
			EDE.color = Color.black;
		if (GameMemory.current.ENDINGS.EDG == true)
			EDG.color = Color.black;
		if (GameMemory.current.ENDINGS.EDH == true)
			EDH.color = Color.black;
		if (GameMemory.current.ENDINGS.EDI == true)
			EDI.color = Color.black;
	}
}
