using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class screen : MonoBehaviour
{

    [SerializeField] GameObject m_screen;
    [SerializeField] GameObject player;
    public float location;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            m_screen.transform.position = new Vector3(location, 0, -10);
        }
    }
}
