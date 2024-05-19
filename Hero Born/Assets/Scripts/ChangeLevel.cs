using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{   int buildindex;
    // Start is called before the first frame update
    void Start()
    {   //initialized buildindex. sets buildindex equal to scene number
        buildindex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider myCollision)
    { 
    //changes level based on world index going from 0 to 3 
    SceneManager.LoadScene(buildindex +1);
       
    }
}
