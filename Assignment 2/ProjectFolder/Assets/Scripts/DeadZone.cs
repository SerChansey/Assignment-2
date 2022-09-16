using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private PlayerPosition _playerPos;
    void Start()
    {
        _playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerPosition>();
    }


    void OnTriggerEnter2D(Collider2D Collision)
    {
        _playerPos.Respawn();
    }
    }
