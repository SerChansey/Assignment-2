using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    private GameController _gameControl;

   
    void Start()
    {
        _gameControl = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject)
        {
            _gameControl._lastRespawn = transform.position;
        }

    }
}
