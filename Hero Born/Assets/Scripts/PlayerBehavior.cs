using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
     private float _vInput;
     
     //_hinput: stores horizantal axis input
    private float _hInput;
    
    //_hinput: stores horizantal axis input
    public float JumpVelocity = 5f;
   
    //holds force applied on jump
    private bool _isJumping;
    
    //reports true/false depending on player jump

    private Rigidbody _rb;
   
    // Start is called before the first frame update
    
     /*
    private variable of type Rigidbody that will contain a reference to the capsule’s
    Rigidbody component
    
    */
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
        //GetComponent method checks whether the component type we’re looking for, in this case, Rigidbody, exists on the GameObject the script is attached to and returns it

    }

    // Update is called once per frame
   
   
    void Update()
    {
    _vInput = Input.GetAxis("Vertical") * MoveSpeed;
    
    //Movespeed: speed player moves forward or backwards
    
    //Input.GetAxis("Vertical") detects when the up arrow, down arrow, W, or S key is pressed and multiplies that value by MoveSpeed
    
     _hInput = Input.GetAxis("Horizontal") * RotateSpeed;
     
     //Rotatespeed: speed rotates left and right
    
    //Input.GetAxis("Horizontal") detects when the left arrow, right arrow, A, or D key is pressed and multiplies that value by RotateSpeed:

    /*
     this.transform.Translate(Vector3.forward *_vInput *Time.deltaTime);
     this.transform.Rotate(Vector3.up *_hInput *Time.deltaTime);
    */
    //Comments out the Transform and Rotate method 
    
    _isJumping |= Input.GetKeyDown(KeyCode.J);
   
   //onlyfires once per frame and returns bool depending on key specified press
   
   //checks if j key pressed
   }
   
   
    void FixedUpdate()
    {
    Vector3 rotation = Vector3.up * _hInput;
    //new Vector3 variable stores left and right rotations

    Quaternion angleRot = Quaternion.Euler(rotation *Time.fixedDeltaTime);
    //Quaternion.Euler takes a Vector3 parameter and returns a rotation value in Euler angles

    _rb.MovePosition(this.transform.position +  this.transform.forward * _vInput * Time.fixedDeltaTime);

    _rb.MoveRotation(_rb.rotation * angleRot);
     /*
    Calls MovePosition on our _rb component, which takes in a Vector3 parameter and
    applies force 
    
    Calls the MoveRotation method on the _rb component, which also takes in a Vector3
    parameter and applies applies force
    */
    
    if(_isJumping)
    //checks if rumping true and activates jump animation
    {
 
        _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
    }
        _isJumping = false;
   
        //resets to false so code knows a jump has been completed.
}
}