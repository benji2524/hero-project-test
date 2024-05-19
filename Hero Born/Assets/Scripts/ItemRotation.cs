using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{ public int RotationSpeed = 100;
  private Transform itemTransform;
    // Start is called before the first frame update
    void Start()
    {   
        //assigns item game object transform component to itemTransform
        itemTransform = this.GetComponent<Transform>();

        
    }

    // Update is called once per frame
    void Update()
    {   //items rotate around x-axis
        itemTransform.Rotate(RotationSpeed*Time.deltaTime, 0, 0);
       
    }
}
