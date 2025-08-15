using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DisplayNote : MonoBehaviour
{
    public GameObject UINote;
    //Enables certain UI elements to only display if the player is on the trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) //On collision trigger, check if the tag of the object is the Player before enabling the object.
        {
            UINote.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            UINote.SetActive(false);
        }
    }
    
}
