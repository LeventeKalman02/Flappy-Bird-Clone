using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    //variables to keep track of score
    [SerializeField] private int playerScore;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text finalScoreText;
    [SerializeField] private GameObject gameOverScreen;
    //reference to audio source
    [SerializeField] private AudioSource pingSFX;

    //to be able to run this function from Unity Editor
    [ContextMenu("Increase Score")]
    //addscore function, with future proofing by making sure only 1 is added to the score at a time
    public void addScore(int scoreToAdd)
    {
        //increase score and set the text to the current score value
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        //plays the ping sound when the score goes up
        pingSFX.Play();
    }
    //loads the player back to the title scene
    public void BackToHome()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    //function to restart the game on game end
    public void RestartGame()
    {
        //get the current scene to restart the game when the button is pressed
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //enables the game over screen when the bird hits a pipe
    public void gameOver()
    {
        scoreText.enabled = false;
        gameOverScreen.SetActive(true);
        //sets the final score text field to the score and disables the score counter
        finalScoreText.text= scoreText.text;
        
    }
}

