using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{ public int RotationSpeed = 100;
  private Transform itemTransform;
    // Start is called before the first frame update
    void Start()
    {
        itemTransform = this.GetComponent<Transform>();

        //assigns item game object transform component to itemTransform
    }

    // Update is called once per frame
    void Update()
    {
        itemTransform.Rotate(RotationSpeed*Time.deltaTime, 0, 0);
        //Transform class method takes in three axe; x, y, z
        // y and z set to 0
        //rotates around x-axis
    }
}
