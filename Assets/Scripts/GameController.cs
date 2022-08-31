using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public int totalScore;
    public Text scoreText;
    
    public GameObject gameOver;

    public static GameController instance;

    public string lvlName;

    public string left;

    public string right;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NewGame()
    {
        SceneManager.LoadScene("facil lvl_1");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Menu()
    {
        SceneManager.LoadScene("main");
    }
    public void Left()
    {
        SceneManager.LoadScene(left);
    }
    public void Right()
    {
        SceneManager.LoadScene(right);
    }
}
