using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour {

    public GameObject treePrefab;

	// Use this for initialization
	void Start () {

        ////CreateTree();
        CreateTree();
    }

    void CreateTree()
    {
        var tree = Instantiate(treePrefab);
        tree.transform.parent = transform;
        tree.transform.localPosition = new Vector3(Random.Range(-50, 50),0,0);
        //tree.transform.Translate(Random.Range(-50, 50), 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
