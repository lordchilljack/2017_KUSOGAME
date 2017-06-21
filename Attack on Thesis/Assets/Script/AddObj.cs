using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddObj : MonoBehaviour {
	public Transform obj;
	public void summon()
	{
		float x = Random.Range (-1.6f, 1.6f);
		Instantiate(obj, new Vector3(x, 1.375f, -2.0f), Quaternion.identity);//召喚既存的Prefab obj 生成在 0, 1.375, -2 會在目前遊戲頂端最前排
	}
}