using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;
	void Start () // Use this for initialization
    {
		
	}
	void Update () // Update is called once per frame
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
        }
	}
}
