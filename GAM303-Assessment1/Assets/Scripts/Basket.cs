using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public Text scoreCounter;
    public int scoreNum;
    void Start () // Use this for initialization
    {
        
	}
	void Update () // Update is called once per frame
    {
        
        Vector3 mousePos2D = Input.mousePosition; //Get the current screen position of the mouse from Input
        mousePos2D.z = -Camera.main.transform.position.z;  // The Camera's z position sets how far to push the mouse into 3D
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D); //Convert the point from 2D screen space into 3D game world space
        //Move the x position of this Basket to the x position of the Mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
	}
    void OnCollisionEnter(Collision coll)
    {
        // Find out what hit this basket
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
            scoreNum += 100;
            scoreCounter.text = scoreNum.ToString();
        }
    }
}
