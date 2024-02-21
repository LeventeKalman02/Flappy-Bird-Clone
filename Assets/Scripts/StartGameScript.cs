using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    //loads the main game when the button is clicked
    public void StartGame()
    {
        //get the current scene to restart the game when the button is pressed
        SceneManager.LoadScene("GameScene");
    }
}
