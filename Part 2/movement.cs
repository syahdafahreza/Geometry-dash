using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(6, rb.velocity.y);

    }

    //So no air jump :)
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "stuff")
        {
            SceneManager.LoadScene("GameOver");
        }
        if(collision.gameObject.tag == "done"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if(collision.gameObject.tag == "ground"){
            if(Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector2(rb.velocity.x, 6);
            }
        }
    }

}
