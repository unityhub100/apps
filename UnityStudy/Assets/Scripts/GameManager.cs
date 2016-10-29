using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GameManager : MonoBehaviour {

    public GameObject[] blcokPrefab = null;
    public List<GameObject> blockList = null;

	// Use this for initialization
	void Start () {
	    for(int i=0; i<10; i++)
        {
            NewBlock(i);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void NewBlock(int y)
    {
        int rand = Random.Range(0, 2);
        Vector2 pos = new Vector2(0, y);
        GameObject block = Instantiate(blcokPrefab[rand], pos, Quaternion.identity) as GameObject;
        blockList.Add(block);

    }
}
