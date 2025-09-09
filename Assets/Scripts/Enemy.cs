using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public Transform A;
    [SerializeField] public Transform B;
    private Transform pos;
    private bool movingToA = true;
    private Rigidbody2D rb;
    public float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        pos = B.transform;
        transform.position = pos.position;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (movingToA)
        {
            transform.position = Vector3.MoveTowards(transform.position, A.position, speed * Time.deltaTime);
            transform.localScale = new Vector3(3.049109f, 2.724077f, 1);

            if (transform.position == A.position) movingToA = false;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, B.position, speed * Time.deltaTime);
            transform.localScale = new Vector3(-3.049109f, 2.724077f, 1);
            if (transform.position == B.position) movingToA = true;

        }


       
    }
    

}
