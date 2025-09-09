using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cut : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject therope;
    private HeroKnight theevent;
    public GameObject bosss;
    private SpriteRenderer dead;
    public Sprite deadd;
    public GameObject back;
    public GameObject thanks;
    public GameObject health;
    public GameObject heart;
    public GameObject coins;
    public GameObject coin;
    void Start()
    {
        dead = GetComponent<SpriteRenderer>();
        theevent = FindObjectOfType<HeroKnight>();
    }

    void Update()
    {
        if (theevent.Boss <= 0)
        {
            Destroy(bosss);
            Destroy(therope);
            rb.gravityScale = 1;
            StartCoroutine(Dead());
        }
    }
    private IEnumerator Dead()
    {
        yield return new WaitForSeconds(1.2f);
        dead.sprite = deadd;
        yield return new WaitForSeconds(2f);
        back.SetActive(true);
        thanks.SetActive(true);
        health.SetActive(false);
        heart.SetActive(false);
        coins.SetActive(false);
        coin.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        Application.Quit();

    }
}
