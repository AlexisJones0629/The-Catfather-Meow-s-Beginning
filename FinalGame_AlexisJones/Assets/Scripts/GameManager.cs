using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public Button nextLevelButton;
    public TextMeshProUGUI congratsText;
    public bool isGameActive;
    public TextMeshProUGUI targetText;
    private int score;
    public TextMeshProUGUI enemiesCount;


   

    // Start is called before the first frame update
    public void Start()
    {
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
      
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
        Time.timeScale = 0;
        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    
    public void UpdateCounter(int Count)
    {
        score += Count;
        enemiesCount.text = "Enemies:" + score;
        if (score == 10)
        {
            Congrats();
        }
    }
    public void Congrats()
    {
        
            congratsText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        nextLevelButton.gameObject.SetActive(true);
        isGameActive = false;
        Time.timeScale = 0;
    }
    public void NextLevelButton()
    {
        SceneManager.LoadScene("Demo");
        Time.timeScale = 1;
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    
}
