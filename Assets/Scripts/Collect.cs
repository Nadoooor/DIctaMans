using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Collect : MonoBehaviour
{
    private Rigidbody2D rb;
    private AudioSource audioSource;
    [SerializeField] private TextMeshProUGUI Coin;
    public int current;     
    public static int coinss = 0;

    private void Start()
    {
        Coin.text = coinss.ToString();
         current = SceneManager.GetActiveScene().buildIndex;
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0; // Disable gravity for the collectible
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("trig");
            coinss++;
            StartCoroutine(Audio(collision));
        }
    }
        private IEnumerator Audio(Collider2D collision)
    {
        audioSource.Play();
        Coin.text = coinss.ToString();
        yield return new WaitForSeconds(audioSource.clip.length);
        Destroy(rb.gameObject);
    }
    public void restartgame()
    {
        if (current == 2)
        {
            coinss = 0;
            Coin.text = coinss.ToString();
        }
        else if (current == 3)
        {
            coinss = 5;
            Coin.text = coinss.ToString();
        }
        else if (current == 4)
        {
            coinss = 18;
            Coin.text = coinss.ToString();
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
