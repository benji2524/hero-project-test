using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{   public Vector3 CamOffset= new Vector3(0f, 1.2f, -2.6f);
//vector3 variable declared to store distance between camera and player

    private Transform _target;

    // Start is called before the first frame update
    void Start()
    {
        _target = GameObject.Find("Player").transform;
        //used to locate the player
    }

    // Update is called once per frame
    void LateUpdate()
    //executes after update
    {
        this.transform.position = _target.TransformPoint(CamOffset);
        this.transform.LookAt(_target);

        //camera follows player
    }
}
