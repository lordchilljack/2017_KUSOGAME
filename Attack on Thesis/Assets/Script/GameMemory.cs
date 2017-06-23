using System.Collections;
using UnityEngine;

[System.Serializable]
public class GameMemory{
	public static GameMemory current;
	public Progression ENDINGS;
	public GameMemory()	{
		ENDINGS = new Progression ();
	}
}
