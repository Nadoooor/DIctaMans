using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class screen_2 : MonoBehaviour
{

    [SerializeField] GameObject m_screen;
    [SerializeField] GameObject player;
    public float locationX;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            m_screen.transform.position = new Vector3(locationX, 0, -10);
        }
    }
}
