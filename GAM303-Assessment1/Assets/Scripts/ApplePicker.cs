using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
    void Start() // Use this for initialization
    {
        basketList = new List<GameObject>();
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate(basketPrefab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
    }
    void Update() // Update is called once per frame
    {

    }
    public void AppleDestroyed()
    {
        // Destory All of the Falling Apples
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }
        //Destory one of the Baskets
        int basketIndex = basketList.Count - 1; // Get the index of the last Basket in basketList
        GameObject tBasketGO = basketList[basketIndex]; //Get a reference to the Basket GameObject
        basketList.RemoveAt(basketIndex); // Remove the Basket from the List and destroy the GameObject
        Destroy(tBasketGO);
        if (basketList.Count == 0)
        {
            SceneManager.LoadScene("_Scene_0");
        }
    }
}
