using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONTTOULER2 : MonoBehaviour {
    public int move;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * move * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * move * Time.deltaTime;
        }
    }
}

