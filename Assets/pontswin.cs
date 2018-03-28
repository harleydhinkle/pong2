using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pontswin : MonoBehaviour {
    ball ball;
	// Use this for initialization
	void Start () {
        ball = GetComponent<ball>();
        
    }
	
	// Update is called once per frame
	void Update () {
		if(ball.pointsone == 5)
        {
            SceneManager.LoadScene(2);
        }
        if (ball.pointstwo == 5)
        {
            SceneManager.LoadScene(3);
        }
	}
}
