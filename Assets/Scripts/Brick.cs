﻿using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
    public int maxHits;
    private int timesHit;

	// Use this for initialization
	void Start () {
        timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
        
	  if(timesHit >= maxHits)
    {
            Destroy(gameObject);

    }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        print("Collision with brick: " + timesHit + "Maxhits: " + maxHits);
    }

}
