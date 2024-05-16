using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    
    //fired when object enters enemy sphere collider radius
 {

    if(other.name == "Player")
    {
        Debug.Log("Player detected - attack!");
    }
}
 
 void OnTriggerExit(Collider other)
 {  
    //code occurs when players exit enemy sphere collider radius

    if(other.name == "Player")
   {
        Debug.Log("Player out of range, resume patrol");
    }
 }
}
