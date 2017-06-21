using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour {
	public Transform obj;
	void FixedUpdate () {
		summon ();
	}
	void summon()
	{		
		{
			Instantiate(obj, new Vector3(0.0f, 1.375f, -2.0f), Quaternion.identity);//召喚既存的Prefab obj 生成在 0, 1.375, -2 會在目前遊戲頂端最前排
		}
	}
}