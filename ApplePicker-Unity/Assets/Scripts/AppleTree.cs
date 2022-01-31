/****
 * Created By: Rohit Khanolkar
 * Date Created: Jan 31, 2022
 * 
 * Last Edited: by; NA
 * Last Edited: Jan 31, 2022
 * 
 * Description: Controls movement of AppleTree
 * 
 * ****/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    //Variables
    public float speed = 1f; //tree speed
    public float leftAndRightEdge = 10f; //distance where the tree turns around
    public GameObject applePrefab; //prefab for instantiating apples
    public float secondsBetweenApplesDropped = 1f; //time between apple drops
    public float chanceToChangeDirections = 0.1f; //chance to change directions
     

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position; //records current position    
        pos.x += speed * Time.deltaTime; //adds speed to the x position
        transform.position = pos; //apply the position value
    }
}
