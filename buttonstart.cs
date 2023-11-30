using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonstart : MonoBehaviour
{
    private Animation anim;
    public string scenename;

    public GameObject tutor;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }


    void Update()
    {
        
    }

    void OnMouseEnter()
	{
        anim.Play("startani");
        tutor.SetActive(true);
	}

    void OnMouseDown()
	{
        	SceneManager.LoadScene(scenename);
	}

    void OnMouseExit()
    {
        tutor.SetActive(false);
    }
}
