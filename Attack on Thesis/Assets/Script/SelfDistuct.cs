using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDistuct : MonoBehaviour {
	float time = 0;
	public float limiter=3;
	void suicide()
	{
		Destroy (gameObject);
	}
	void Update()
	{
		time += Time.deltaTime;
		if (time >= limiter) 
		{
			suicide ();
		}
	}
}
