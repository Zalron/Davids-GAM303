﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour 
{
	GameObject Cube;
	public float movementSpeed = 1;
	void Start () // Use this for initialization
	{
		
	}
	void Update () // Update is called once per frame
	{
		if(Input.GetKeyDown(KeyCode.W))
		{
			transform.position += (Vector3.forward)*movementSpeed;
		}
		if(Input.GetKeyDown(KeyCode.A))
		{
			transform.position += (Vector3.left)*movementSpeed;
		}
		if(Input.GetKeyDown(KeyCode.D))
		{
			transform.position += (Vector3.back)*movementSpeed;
		}
		if(Input.GetKeyDown(KeyCode.S))
		{
			transform.position += (Vector3.right)*movementSpeed;
		}
	}
}
