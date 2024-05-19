using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
    //_hinput: stores vertical axis input
     private float _vInput;
     
     //_hinput: stores horizantal axis input
    private float _hInput;
    
    //holds force applied on jump
    public float JumpVelocity = 5f;
   
    
    private bool _isJumping;
    
    

    private Rigidbody _rb;
     
    
    
   
    
   
    // Start is called before the first frame update
    

    void Start()
    {
         //checks for rigidbody
        _rb = GetComponent<Rigidbody>();
        
       
    }

    // Update is called once per frame
   
   
    void Update()
    {
    _vInput = Input.GetAxis("Vertical") * MoveSpeed;
    
    //detects when the up arrow, down arrow, W, or S key is pressed
    
     _hInput = Input.GetAxis("Horizontal") * RotateSpeed;
     
     //detects when the left arrow, right arrow, A, or D key pressed

    /*
     this.transform.Translate(Vector3.forward *_vInput *Time.deltaTime);
     this.transform.Rotate(Vector3.up *_hInput *Time.deltaTime);
    */
    
    
    _isJumping |= Input.GetKeyDown(KeyCode.J);
   
   //onlyfires once per frame and returns bool depending on key specified press
   
   //checks if j key pressed
   }
   
   
    void FixedUpdate()
    {
    Vector3 rotation = Vector3.up * _hInput;
    //new Vector3 variable stores left and right rotations

    Quaternion angleRot = Quaternion.Euler(rotation *Time.fixedDeltaTime);
    //a Vector3 parameter and returns a rotation value in Euler angles

    _rb.MovePosition(this.transform.position +  this.transform.forward * _vInput * Time.fixedDeltaTime);

    _rb.MoveRotation(_rb.rotation * angleRot);
     /*
    Calls MovePosition on our _rb component, which takes in a Vector3 parameter and
    applies force 
    
    Calls the MoveRotation method on the _rb component, which also takes in a Vector3
    parameter and applies applies force
    */
     
     //checks if rumping true and activates jump animation
    if(_isJumping)
    {
 
        _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
    }
        //resets to false so code knows a jump has been completed.
        _isJumping = false;
   
        
}
}