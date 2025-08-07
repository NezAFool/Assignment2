using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckBox : MonoBehaviour
{
    
    private bool CheckIfReal = false;
    

    public bool checkTotal() 
    {
        bool checkInternal = CheckIfReal;
        return checkInternal;
        
    }

    public void CheckIfwork() 
    {
        Debug.Log("Recieved Script");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Crate")
        {
            CheckIfReal = true;
            
            checkTotal();
        }
        else if (collision.tag == "FakeBox")
        {
            SceneManager.LoadScene(0);
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Crate")
        {
            CheckIfReal = false;
            
            checkTotal();
            
        }
    }
}
