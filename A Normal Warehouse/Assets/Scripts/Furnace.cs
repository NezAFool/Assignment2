using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furnace : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other) /*Checks if the object that collided with it 
                                                     * is a real Crate 
                                                     * or a fake before destroying it*/
    {
        if (other.gameObject.CompareTag("Crate") || other.gameObject.CompareTag("FakeBox"))
        {
            Destroy(other.gameObject);
        }
        Debug.Log("Burn");
        
    }
    
}
