using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win1 : MonoBehaviour
{
    public GameObject win;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            win.SetActive(true);
        }
    }

    public void Win()
    {
        SceneManager.LoadScene(3);
        win.SetActive(false);
    }
    
}
