﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlatLRMove : MonoBehaviour
{
    float x;
    Rigidbody2D rb;
    int RLD = 1;
    public float speed = 1;
    public int Range = 5;//범위

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        x = transform.position.x;
	}
	
	// Update is called once per frame
	void Update ()
    {
        rb.velocity = (new Vector2(speed*RLD, 0));

        if (this.transform.position.x - x<-5)
        {
            RLD = 1;
        }

        if (this.transform.position.x-x >5)
        {
            RLD = -1;
        }
    }
}
