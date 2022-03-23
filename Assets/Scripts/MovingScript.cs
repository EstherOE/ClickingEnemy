using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MovingScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    Animator anime;
    public EnemyInfoScriptableObject obj;
    private float dirx;
    [SerializeField]private float speed;
    Rigidbody2D body;
    private bool isFacingRight = true;
    private Vector3 localScale;
    public void Start()
    {
        text.text = obj.name;
        anime = GetComponent<Animator>();
        localScale = transform.localScale;
        body = GetComponent<Rigidbody2D>();
        dirx = 1f;
        
    }
    // Update is called once per frame
    void Update()
    {

     
    }
    private void FixedUpdate()
    {
        body.velocity = new Vector2(dirx * speed, body.velocity.y);
    }

    private void LateUpdate()
    {
        CheckedWheretoface();
    }

    private void CheckedWheretoface()
    {
        if (dirx > 0)
            isFacingRight = true;
        else if (dirx < 0)
            isFacingRight = false;

        if (((isFacingRight) && (localScale.x < 0)) || ((!isFacingRight) && (localScale.x > 0)))
            localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Wall>())
        {
            dirx *= -1f;
        }
    }
}
