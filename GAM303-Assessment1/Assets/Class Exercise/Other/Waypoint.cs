using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Waypoint : MonoBehaviour 
{
	Waypointholder waypointholder;
	public void Start()
	{
		waypointholder = GameObject.Find ("WaypointHolder").GetComponent<Waypointholder> ();
	}
	public void OnTriggerEnter (Collider col)
	{
		if (col.name == "ColliderBottom") 
		{
			waypointholder.Updatescore ();
		}
	}
}
