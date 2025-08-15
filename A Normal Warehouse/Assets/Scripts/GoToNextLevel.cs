using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLevel : MonoBehaviour
{
    int anomal = 0;
    int SceneID = 0;
    CheckRightPos checkAllBox;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (anomal > 0)/*anomal is the amount of fake boxes left in the level. 
                        * If any remain, attempting to proceed to the next level will reset 
                        * the current one instead*/
        {
            SceneManager.LoadScene(SceneID);
        }
        else if (checkAllBox.CorrectBox)
        {
            if (other.tag == "Player")
            {
                SceneManager.LoadScene(SceneID + 1);
            }
        }
       
    }
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneID = currentScene.buildIndex;
        Debug.Log($"{SceneID}");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject gameManage = GameObject.FindGameObjectWithTag("GameManager");
        checkAllBox = gameManage.GetComponent<CheckRightPos>();//Used to recieve the CorrectBox bool to check if all crates are in place
        GameObject[] anomally = GameObject.FindGameObjectsWithTag("FakeBox");
        anomal = anomally.Length;
    }
}
