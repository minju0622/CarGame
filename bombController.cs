﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombController : MonoBehaviour
{
    public GameObject trash;

    void OnCollisionEnter2D(Collision2D Col)
    {
        GameObject hp = GameObject.Find("HPControl");

            if (Col.gameObject.tag == "Player")
            {
                hp.GetComponent<HpController>().HpControl();
            }

            Destroy(gameObject);
        }

            
}
