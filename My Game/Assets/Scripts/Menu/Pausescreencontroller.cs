using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Pausescreencontroller : MonoBehaviour
{
    private InputManager inputManager;
    private Playermovement playermovement;
    [SerializeField] private GameObject pauseMenu;
    private void Awake()
    {
        inputManager = new InputManager();
        playermovement = GetComponent<Playermovement>();
        inputManager.Enable();
        Time.timeScale = 1;
    }
    public void Update()
    {
        if (inputManager.Land.Esc.triggered == true)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        
    }
    public void ContinueGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        
    }
    
}
