﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoulville_Manager : MonoBehaviour {
    public int Scoulville;
    public int Health=100;
	// Use this for initialization
	void Start () {
        Scoulville = 0;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GetScoulville(int scouls)
    {
        Scoulville += scouls;
    }

    public void UseScoulville(int scouls)
    {
        Scoulville -= scouls;
    }
}
