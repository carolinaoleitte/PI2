using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    public Vector3 size;
    public Vector3 center;
    public GameObject obj;
	void Start () {
        Spawn_Obj();
	}
	
	void Update () {
        if (Input.GetKey("."))
        {
            Spawn_Obj();
        }
    }
    public void Spawn_Obj()
    {
        Vector3 pos = new Vector3(Random.Range(-size.x, size.x), 0, Random.Range(-size.z, size.z));
        Instantiate(obj, pos, Quaternion.identity);
    }
}
