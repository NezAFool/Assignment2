using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckBox : MonoBehaviour
{
    
    private bool CheckIfReal = false;
    //CheckIfReal is used to check if the end point has a crate on it

    public bool checkTotal() 
    {
        bool checkInternal = CheckIfReal;
        return checkInternal;
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Crate")
        {
            CheckIfReal = true;
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Crate")
        {
            CheckIfReal = false;
            
            
        }
    }
}
