using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab; //Prefab for instantiating apples
    public float speed = 10f; // Speed at which the AppleTree moves ion m/s
    public float leftAndRightEdge = 10f; // Distance where AppleTree truns around
    public float chanceToChangeDiections = 0.02f; // Chance that the AppleTree will change directions 
    public float secondsBetweenAppleDrops = 1f; // Rate at whiich Apples will be instantiated
    void Start () // Use this for initialization
    {
		//Dropping Apples every second
		InvokeRepeating("DropApple", 2f, secondsBetweenAppleDrops);
	}
	void Update () // Update is called once per frame
    {
        //Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        //Changing Direction
        if (pos.x < -leftAndRightEdge) // Move right
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge) // Move left
        {
            speed = -Mathf.Abs(speed);
        }
	}
    void FixedUpdate()
    {
        if (Random.value < chanceToChangeDiections) // Chage direction Randomly
        {
            speed *= -1;
        }
    }
	void DropApple()
	{
		GameObject apple = Instantiate (applePrefab) as GameObject;
		apple.transform.position = transform.position;
	}
}
