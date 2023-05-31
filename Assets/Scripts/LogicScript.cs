using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // Identifies the player score, the gameover screen, and the text that counts the score
public int playerScore;
public Text scoreText;
public GameObject gameOverScreen;
//Adds the Increase score option in the inspector
[ContextMenu("Increase Score")]

public void addScore(int scoreToAdd){
//Allows the players score to be equal the score that is added. (Player score + 1 everytime it goes through the pipe)
    playerScore = playerScore + scoreToAdd;
    //Update the score text
    scoreText.text = playerScore.ToString();
}

public void restartGame(){
    //When the game is resstarted the scene reloads
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

public void GameOver(){
    //The game over screen is displayed when the player dies
gameOverScreen.SetActive(true);
}
}