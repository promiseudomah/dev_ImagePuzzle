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
    }

    #endregion


    public void LoadMenu(){
        
        SceneManager.LoadScene(0);
    }

    public void LevelComplete()
    {   
        
        LevelCompleteScreen.SetActive(true);
    }
    

}
