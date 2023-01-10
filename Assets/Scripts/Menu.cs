using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
  
    public void ExitGame()
    {
        Debug.Log("Estoy saliendo");
        Application.Quit();
    }



}
