using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void ExitButton(){ //ETO PARA SA EXIT
         Application.Quit ();
         Debug.Log("Game is exiting");

   }
    public void ext(){ //ETO PARA SA EXIT
        Debug.Log("GFagaga");

   }

   public void StartGame(){ //ETO PARA SA START GAME
       SceneManager.LoadScene("Game Scene");

   }
}
