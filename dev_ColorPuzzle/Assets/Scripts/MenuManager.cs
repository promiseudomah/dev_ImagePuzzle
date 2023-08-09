using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void LoadLevel(int levelIndex){
        
        SceneManager.LoadScene(levelIndex);   
    }

    public void Quit(){

        Application.Quit();
    }
}
