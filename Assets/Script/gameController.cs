using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameController : MonoBehaviour {
    public GameObject pnlEndGame;
    public Text txtpoint;
    public Button btnRestart;

    public GameObject pnlStart;
    public Button btnStart;

    public Text txtScenePoint;

    public bool isEndGame;
    public bool isStartGame;

    public GameObject pnlHighPoint;
    public Text txtHighPoint;
    public Text txtHighPoint2;
    public Text txtHighPoint3;

    int gamePoint = 0;
    int scenePoint = 0;
    

    private Animation anim;
    // Use this for initialization
    void Start()
    {
        pnlStart.SetActive(true);
        pnlEndGame.SetActive(false);
        pnlHighPoint.SetActive(false);
        isEndGame = false;
        isStartGame = true;

    }

    // Update is called once per frame
    void Update() {

    }
    public void EndGame()
    {
        isEndGame = true;
        isStartGame = false;
        txtpoint.text = "your point\n" + scenePoint.ToString();

        pnlEndGame.SetActive(true);
        
       
    }

    public void StartGame()
    {
        isStartGame = false;
        pnlStart.SetActive(false);
    }
    public void ReStartGame()
    {
        SceneManager.LoadScene(0);
    }
    public void openHighPoint()
    {
        pnlHighPoint.SetActive(true);
    }
    public void exitHighPoint()
    {
        pnlHighPoint.SetActive(false);
    }
    public void GetPoint()
    {
        if (!isEndGame)
        {
            gamePoint++;
        }
        scenePoint = gamePoint - 1;
        txtScenePoint.text = scenePoint.ToString();
    }
    
}
