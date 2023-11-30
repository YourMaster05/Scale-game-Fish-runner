using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    // Start is called before the first frame update
    void Start()
    {
        GameObject panel1 = GameObject.Find("Panel");
        GameObject panel2 = GameObject.Find("PanelEndTime");
        GameObject panel3 = GameObject.Find("Panel All Scales");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		    Debug.Log("Restart");
            ObstacleMove.moveSpeed = 10;

            GameObject player = GameObject.Find("Player");
            player.GetComponent<Collider2D>().enabled = true;
            panel1.SetActive(false);
            panel2.SetActive(false);
            panel3.SetActive(false);

            Player.score = 0;
        }

    }
}
