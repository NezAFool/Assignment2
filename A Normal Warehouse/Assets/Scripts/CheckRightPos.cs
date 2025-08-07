using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckRightPos : MonoBehaviour
{
    [SerializeField]
    public CheckBox checkbox;
    GameObject[] endPoints;
    
    public int totalBox = 0;
    
    private bool CorrectBox = false;
    

    private void Awake()
    {
        

    }
    void Start()
    {
        //checkbox.CheckIfwork();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        endPoints = GameObject.FindGameObjectsWithTag("EmptySpots");
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
            if (CorrectBox) 
            {
                Debug.Log("All Boxes Placed");
            }
        }
        
    }
}
