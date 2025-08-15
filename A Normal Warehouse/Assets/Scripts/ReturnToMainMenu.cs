using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class ReturnToMainMenu : MonoBehaviour
{
    public Button startGame;
    // Start is called before the first frame update
    void Start()
    {
        Button startGame = GetComponent<Button>();
        startGame.onClick.AddListener(ReturnToMenu); //On click runs ReturnToMenu which loads the start menu scence
    }

    
    void ReturnToMenu()
    {
        Debug.Log("return to main menu");
        SceneManager.LoadScene(0);
    }
}
