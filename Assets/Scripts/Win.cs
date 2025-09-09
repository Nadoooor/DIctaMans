using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject win;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            win.SetActive(true);
        }
    }

    public void Win0()
    {
        SceneManager.LoadScene(4);
        win.SetActive(false);
    }
    
}
