using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour {

	public Texture2D tex;
	public Sprite newBox;
	private SpriteRenderer sr;
	void Awake () {
		sr = gameObject.AddComponent<SpriteRenderer> () as SpriteRenderer;
		sr.color = new Color (1.0f,0.0f,0.0f);
		transform.position = new Vector3 (0, 0, 0);
	}

	void Update () {
		
	}
}
