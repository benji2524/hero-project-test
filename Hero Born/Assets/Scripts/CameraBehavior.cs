using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{   //vector3 variable declared to store distance between camera and player
    public Vector3 CamOffset= new Vector3(0f, 1.2f, -2.6f);


    private Transform _target;

    // Start is called before the first frame update
    void Start()
    {   //used to locate the player
        _target = GameObject.Find("Player").transform;
       
    }

    // Update is called once per frame
    void LateUpdate()
    
    {    //camera follows player
        this.transform.position = _target.TransformPoint(CamOffset);
        this.transform.LookAt(_target);

        
    }
}
