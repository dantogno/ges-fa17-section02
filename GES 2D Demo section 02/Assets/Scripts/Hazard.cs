﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerRespawn playerRespawn = 
                collision.gameObject.GetComponent<PlayerRespawn>();

            playerRespawn.Respawn();           
        }
    }
}
