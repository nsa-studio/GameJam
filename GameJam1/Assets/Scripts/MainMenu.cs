using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    
    public void NewGame() 
    {
        
        Debug.Log("Новая игра");
        SceneManager.LoadScene(1);
        
    }

    public void ExitGame() 
    {
        Debug.Log("Выход");
        Application.Quit();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
