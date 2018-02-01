﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public GameObject square;
    public List<GameObject> emojis;
    public GameObject panel;

    public Vector3 panel_spawn;

    private void Awake()
    {
        //singleton setup
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnPanel());
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetMouseButtonDown(0))
        {
            //Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //print(pz);
            //GameObject temp = Instantiate(square);
            //temp.transform.position = new Vector3(pz.x, pz.y, 0);
        }
    }

    IEnumerator SpawnPanel()
    {
        while (true)
        {
            GameObject new_panel = Instantiate(panel);
            new_panel.transform.position = (panel_spawn + new Vector3(0, Random.Range(-3f, 3f), 0));
            yield return new WaitForSeconds(2);
        }
    }
}
