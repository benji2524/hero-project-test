using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ItemBehavior : MonoBehaviour
{
 // 1
 void OnCollisionEnter(Collision collision)
 {
 // 2
 if(collision.gameObject.name == "Player")
 {
 // 3
 Destroy(this.transform.gameObject);
 // 4
 Debug.Log("Item collected!");
 }
 }
} 