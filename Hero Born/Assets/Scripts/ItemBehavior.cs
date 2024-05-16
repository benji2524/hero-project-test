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
   //another object runs into the Item Prefab, Unity automatically calls the OnCollisionEnter method
   
   //OnCollisionEnter comes with a parameter that stores a reference to the Collider that ran into it
 
 if(collision.gameObject.name == "Player")
 {

   //Collision class has a property, called gameObject, that holds a reference to the colliding GameObject’s Collider
    
    Destroy(this.transform.gameObject);
   
   //removes collectible on player condition

    Debug.Log("Item collected!");

   //prints "item collected" on player collision
 }
 }
} 