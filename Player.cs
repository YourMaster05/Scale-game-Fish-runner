using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public bool playerIsActive = true;
    public float speed;

    public static int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreTextFinal;
//    public TextMeshProUGUI scalesAmount;
    public float changeSpeed = 0.01f;
    public float changeMoveSpeed = 1f;

    public GameObject panel;
    public GameObject panelScore;
    public GameObject panelAllScales;

    public GameObject scale10;
    public GameObject scale20;
    public GameObject scale30;
    public GameObject scale40;
    public GameObject scale50;
    public GameObject scale60;
    public GameObject scale70;
    public GameObject scale80;
    public GameObject scale90;
    public GameObject scale100;
    private GameObject player;

    public GameObject timer;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("FFFFFFFFFFFFFFF");
	    panel.SetActive(false);
        panelAllScales.SetActive(false);
        panelScore.SetActive(true);
        player = GameObject.Find("Player");
        player.GetComponent<Collider2D>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        ObstacleMove.moveSpeed += Time.deltaTime * changeMoveSpeed;

        if(ObstacleMove.moveSpeed >= 25f)
        {
            ObstacleMove.moveSpeed = 25f;
        }

        speed += Time.deltaTime * changeSpeed;

        if(speed >= 11f)
        {
            speed = 11f;
        }

        transform.position += new Vector3(0, Input.GetAxis("Vertical"), 0) * Time.deltaTime * speed;
        scoreText.text = "Score: " + score;
    	scoreTextFinal.text = "Score: 0";

        //смена спрайта персонажа
        if(score == 10)
        {
            scale10.SetActive(true);
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (score == 20)
        {
            scale10.SetActive(false);
            scale20.SetActive(true);
        }
        if (score == 30)
        {
            scale20.SetActive(false);
            scale30.SetActive(true);
        }
        if (score == 40)
        {
            scale30.SetActive(false);
            scale40.SetActive(true);
        }
        if (score == 50)
        {
            scale40.SetActive(false);
            scale50.SetActive(true);
        }
        if (score == 60)
        {
            scale50.SetActive(false);
            scale60.SetActive(true);
        }
        if (score == 70)
        {
            scale60.SetActive(false);
            scale70.SetActive(true);
        }
        if (score == 80)
        {
            scale70.SetActive(false);
            scale80.SetActive(true);
        }
        if (score == 90)
        {
            scale80.SetActive(false);
            scale90.SetActive(true);
        }
        if (score == 100)
        {
            scale90.SetActive(false);
            scale100.SetActive(true);
        }

        //активация панелей
        if (score <= -1)
        {
            score = 0;
            panel.SetActive(true);
            panelScore.SetActive(false);
            timer.SetActive(false);
            GameObject player = GameObject.Find("Player");
            player.GetComponent<Collider2D>().enabled = false;
        }

        if(score == 100)
        {
            score = 0;
            panelAllScales.SetActive(true);
            panelScore.SetActive(false);
            timer.SetActive(false);
            GameObject player = GameObject.Find("Player");
            player.GetComponent<Collider2D>().enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 4)
	    {
            score -= 1;
            Destroy(collision.gameObject);
		    //panel.SetActive(true);
		    //panelScore.SetActive(false);

	    }
        //чешуя
    else if (collision.gameObject.layer == 3)
        {
            Destroy(collision.gameObject);
            score += 1;
        }
    //    //бонус?
    //else if (collision.gameObject.layer == 6)
    //    {
    //        Destroy(collision.gameObject);
    //        score += 50;
    //    }
    }
}
