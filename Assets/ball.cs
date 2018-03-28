using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour {
    public Rigidbody rm;
    Vector3 vel;
    public Vector3 startpos;
    public Text pointone;
    public Text pointtwo;
    public int pointsone;
    public Vector3 dir;
    public int pointstwo;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            rm.velocity *= -1; 
        }
        if(other.tag == "bottomone")
        {
            if (rm.velocity.z > 0)
            {
                dir = rm.velocity;
                dir.z *= 1;
                rm.velocity = dir;
            }
            
        }
        if(other.tag == "topone")
        {
            if (rm.velocity.z < 0)
            {
                dir = rm.velocity;
                dir.z *= -1;
                rm.velocity = dir;
            }

        }
        if (other.tag == "walls")
        {
            if (rm.velocity.z > 0)
            {
                dir = rm.velocity;
                dir.z *= 1;
                rm.velocity = dir;
            }
            if (rm.velocity.z < 0)
            {
                dir = rm.velocity;
                dir.z *= -1;
                rm.velocity = dir;
            }
        }
        if (other.tag == "wall2")
        {
            if (rm.velocity.z < 0)
            {
                dir = rm.velocity;
                dir.z *= 1;
                rm.velocity = dir;
            }
            if (rm.velocity.z > 0)
            {
                dir = rm.velocity;
                dir.z *= -1;
                rm.velocity = dir;
            }
        }
        if (other.tag == "player one points")
        {
            pointsone += 1;
            SetplayeroneText();
            transform.position = startpos;
        }
        if (other.tag == "player two point")
        {
            SetplayertwoText();
            pointstwo += 1;
            transform.position = startpos;
        }
    }
    // Use this for initialization
    void Start () {
       
        SetplayeroneText();
        SetplayertwoText();
        pointsone = 0;
        pointstwo = 0;
    startpos = transform.position;
        Vector3 rand = Random.insideUnitCircle;
        Vector3 dea = new Vector3(rand.x, 0, rand.y);
        rm.AddForce(dea* 3, ForceMode.Impulse);
    }
	
	// Update is called once per frame
	void Update () {
        SetplayeroneText();
        SetplayertwoText();
    }
    void SetplayeroneText()
    {
        pointone.text =  pointsone.ToString();
    }
    void SetplayertwoText()
    {
        pointtwo.text =  pointstwo.ToString();
    }
}
