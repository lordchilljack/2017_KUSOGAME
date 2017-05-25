using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour {
	public Transform target;
	void Update () {
		Vector3 dest = new Vector3 (target.position.x , target.position.y , -1);
		transform.position = (dest);

	}
}
