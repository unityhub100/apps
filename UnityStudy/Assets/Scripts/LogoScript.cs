using UnityEngine;
using System.Collections;

public class LogoScript : MonoBehaviour {
    public float delayTime = 3;
    
	// Use this for initialization
	IEnumerator Start () {
        yield return new WaitForSeconds(delayTime);

        Application.LoadLevel("GameScene");
	}
}
