using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndScreen : MonoBehaviour
{
    public TextMeshProUGUI High;
    public TextMeshProUGUI Curr;
    
    private void Start()
    {
    High.text = "High Score-"+((int)PlayerPrefs.GetFloat("HighScore", 0)).ToString();
    Curr.text = "Your Score-"+ PlayerPrefs.GetInt("CurrentScore", 0);
    PlayerPrefs.DeleteKey("CurrentScore");
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene(0);
    }public void Exit()
    {
        Application.Quit();
    }
}
