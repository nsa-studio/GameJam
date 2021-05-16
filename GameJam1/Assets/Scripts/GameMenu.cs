using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public GameObject MenuUI;
    public void MineMenu()
    {
        
        Debug.Log("Главное меню");
        SceneManager.LoadScene(0);

    }
    public void RestartGame()
    {

        Debug.Log("Перезапуск уровня");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //Перезагрузка сцены
        
    }
    public void ResumeButton()
    {
        Time.timeScale = 1;
        MenuUI.gameObject.SetActive(false);
    }

    public void ExitGame()
    {
        Debug.Log("Выход");
        Application.Quit();

    }


    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    void Start()
    {
        MenuUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Меню");
            Time.timeScale = 0;
            MenuUI.gameObject.SetActive(true);
        }
    }
}
