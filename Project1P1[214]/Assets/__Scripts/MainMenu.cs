using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This class is responsible for handling the operations of the Main Menu of the game.
public class MainMenu : MonoBehaviour              
{
   public void PlayGame()
    {
        //This loads the first level of the game upon clicking the Play Button.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);              
    }
    public void QuitGame()
    {
        //This quits out of the game upon clicking the "Quit" button.
        Application.Quit();            
    }

    public void CharacterSelectionScreen()
    {
        //Upon clicking the options menu, the scence changes to a character selection screen.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void LoadStartScreen()
    {
        //This is to contorl a button to go back to the start screen when you are on the character selection screen.
        SceneManager.LoadScene("StartScreen");  
    }
  
   
}
