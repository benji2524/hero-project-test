using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
     private float _vInput;
    private float _hInput;
    private Rigidbody _rb;
    // Start is called before the first frame update
    
    // _vInput: stores vertical axis input
    
    //_hinput: stores horizantal axis input
    
    /*
    private variable of type Rigidbody that will contain a reference to the capsule’s
    Rigidbody component
    
    */
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        //e GetComponent method checks whether the component type we’re looking for, in this case, Rigidbody, exists on the GameObject the script is attached to and returns it

    }

    // Update is called once per frame
    void Update()
    {
    _vInput = Input.GetAxis("Vertical") * MoveSpeed;
     _hInput = Input.GetAxis("Horizontal") * RotateSpeed;
     /*
     this.transform.Translate(Vector3.forward *_vInput *Time.deltaTime);
     this.transform.Rotate(Vector3.up *_hInput *Time.deltaTime);
      */
    
    //Comments out the Transform and Rotate method c

    //Movespeed: speed player moves forward or backwards
    
    //Rotatespeed: speed rotates left and right
   
   //Input.GetAxis("Vertical") detects when the up arrow, down arrow, W, or S key is pressed and multiplies that value by MoveSpeed:
 
   //Input.GetAxis("Horizontal") detects when the left arrow, right arrow, A, or D key is pressed and multiplies that value by RotateSpeed:

       
    }
    void FixedUpdate()
    {
    Vector3 rotation = Vector3.up * _hInput;

    Quaternion angleRot = Quaternion.Euler(rotation *Time.fixedDeltaTime);

    _rb.MovePosition(this.transform.position +  this.transform.forward * _vInput * Time.fixedDeltaTime);

    _rb.MoveRotation(_rb.rotation * angleRot);
    //new Vector3 variable stores left and right rotations
    
    //Quaternion.Euler takes a Vector3 parameter and returns a rotation value in Euler angles
    
    /*
    Calls MovePosition on our _rb component, which takes in a Vector3 parameter and
    applies force 
    
    Calls the MoveRotation method on the _rb component, which also takes in a Vector3
    parameter and applies applies force

    */

    }
}
