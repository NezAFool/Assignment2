using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckRightPos : MonoBehaviour
{
    GameObject[] crates;
    int scenceNo = 0;
    public CheckBox checkbox;
    GameObject[] endPoints;
    
    public int totalBox = 0;
    
    public bool CorrectBox = false;
    

    private void Awake()
    {
        Scene scene = SceneManager.GetActiveScene();
        scenceNo = scene.buildIndex;
        //sceneNo is the current scene Index
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
        crates = GameObject.FindGameObjectsWithTag("Crate");//Array of gameObjects with the tag Crate for number of crates in the level
        endPoints = GameObject.FindGameObjectsWithTag("EmptySpots");//Array of gameObjects with the tag EmptySpots for the number of empty spots in the level
        if (crates.Length < endPoints.Length) 
        {
            SceneManager.LoadScene(scenceNo);
        }//Resets level if a real crate is destroyed
        foreach (GameObject end in endPoints)
        {
            CheckBox box = end.GetComponent<CheckBox>();
            if (box != null)
            {
                box.checkTotal();
                if (box.checkTotal())
                {
                    CorrectBox = true;
                }
                else 
                {
                    CorrectBox = false;
                    break;
                }
            }
        }//Checks if each end point has a crate on it. 
        if (CorrectBox)
        {
            Debug.Log("All Boxes Placed");
        }//Debug
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            SceneManager.LoadScene(scenceNo);
        }//Restart level
        ;
    }
}
