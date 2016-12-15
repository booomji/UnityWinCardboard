using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLane : MonoBehaviour {

    public GameObject[] spawnLaneArray;

	// Use this for initialization
	void Start () {
        SpawnFunc(0);
        SpawnFunc(10);
        SpawnFunc(20);
        

    }

    void SpawnFunc(float offset)
    {
        int randPrefab = Random.Range(0,spawnLaneArray.Length);
        var prefabInst = Instantiate(spawnLaneArray[randPrefab]);
        prefabInst.transform.SetParent(this.transform);
        prefabInst.transform.Translate(0,0,offset);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
