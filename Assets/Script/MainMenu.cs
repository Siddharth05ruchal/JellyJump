using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OpenStore() 
    {
        SceneManager.LoadScene("StoreMenu");
    }
    public void CloseStore()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
