using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class start : MonoBehaviour {	// Use this for initialization



         public void ChangeScene(string scenename)
    {
        Application.LoadLevel(scenename);
    }


}
