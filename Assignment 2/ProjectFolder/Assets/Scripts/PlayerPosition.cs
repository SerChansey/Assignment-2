using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPosition : MonoBehaviour
{
    private GameController _gameControl;

    void Start()
    {
        _gameControl = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

    }

    //respawn tester/debug
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Respawn();
            
        }
    }

    public void Respawn()
    {
        GameController._treasureCounter -= 10;
        GameController._deathCounter += 1;
        transform.position = _gameControl._lastRespawn;
    }

}
