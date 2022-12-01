using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    public Rigidbody2D rigidbod;
    public Transform player;
    public bool alive;
    public static int brick_num = 14;

    private AudioSource sound;
    public AudioClip clip;
    //public ScoreKeeper scorekeeper;

    // Start is called before the first frame update
    void Start()
    {
        rigidbod = GetComponent<Rigidbody2D>();
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (LifeKeeper.gameover | ScoreKeeper.gameover)
        {
            return;
        }
        if (!alive)
        {
            transform.position = new Vector2(player.position.x, player.position.y+0.55f);
        }
        if (Input.GetMouseButtonDown(0) && alive == false)
        {
            alive = true;
            rigidbod.AddForce(Vector2.up * 400);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bottom"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            alive = false;
            brick_num = 14;
            LifeKeeper.SubtractLife();
            rigidbod.velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Bricks"))
        {
            brick_num -= 1;
            Destroy(collision.gameObject);
            ScoreKeeper.AddToScore(10, brick_num);
            sound.PlayOneShot(clip, 1);
        }
    }
}
