using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conttouler : MonoBehaviour {
    public int move;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
            {
            transform.position += Vector3.forward * move * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * move * Time.deltaTime;
        }
    }
}
