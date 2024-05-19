using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ItemBehavior : MonoBehaviour
{

 void OnCollisionEnter(Collision collision)
 {
   
 //triggers on item collision
if(collision.gameObject.name == "Player")
 {

  
    
    //removes collectible on player condition
    Destroy(this.transform.gameObject);
   
   

    Debug.Log("Item collected!");

   
 }
 }
} 