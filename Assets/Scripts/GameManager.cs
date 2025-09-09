using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] public GameObject Gameover;
    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

        }
        Time.timeScale = 1f;

    }
    public void gameover()
    {
        Gameover.SetActive(true);
        Time.timeScale = 0f;
    }
        public void RestartGame()
    {   
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
