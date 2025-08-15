using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    //The script is attached to the start button on the UI layer
    public Button startGame;
    // Start is called before the first frame update
    void Start()
    {
        Button startGame = GetComponent<Button>();
        startGame.onClick.AddListener(Check);
    }
    void Check()
    {
        Debug.Log("Start Game");
        SceneManager.LoadScene(1);
    }
}
