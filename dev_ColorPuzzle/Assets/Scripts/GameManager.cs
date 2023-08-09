using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   
    [Space(10)]
    [Header("Game Manager Screens")]
    public GameObject LevelCompleteScreen;

    #region Singleton

    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
        LevelCompleteScreen.SetActive(false);
    }

    #endregion


    public void LoadMenu(){
        
        SceneManager.LoadScene(0);
    }

    public void LevelComplete()
    {   
        
        LevelCompleteScreen.SetActive(true);
    }

    public void NextLevel(){
        
        int nextLevelIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if(SceneManager.GetSceneByBuildIndex(nextLevelIndex) == null){
            
            LoadMenu();
            return;
        }

        SceneManager.LoadScene(nextLevelIndex);
    }
    

}
