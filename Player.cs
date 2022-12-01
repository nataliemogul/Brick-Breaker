using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Score;
    public float speed;
    public float leftSide;
    public float rightSide;
    //public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LifeKeeper.gameover | ScoreKeeper.gameover)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0);
        }

        //float horizontal = Input.GetAxis("Horizontal");

        //transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);

        //if (transform.position.x < leftSide)
        //{
        //    transform.position = new Vector2(leftSide, transform.position.y);
        //}
        //if (transform.position.x > rightSide)
        //{
        //    transform.position = new Vector2(rightSide, transform.position.y);
        //}
    }
}
