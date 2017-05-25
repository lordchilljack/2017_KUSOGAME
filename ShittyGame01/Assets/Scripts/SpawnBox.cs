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
		if (Input.GetKeyDown (KeyCode.X)) //按下X鍵
		{
			Instantiate(obj, new Vector3(0, 0, 0), Quaternion.identity);//召喚既存的Prefab obj 生成在0,0,0
		}
	}
}
