using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{

    private bool _isColliding = false;

    void OnTriggerEnter2D(Collider2D Collision)
    {
        if (_isColliding) return;
        GameController._treasureCounter += 50;
        StartCoroutine(Reset());
        Destroy(gameObject);
    }
    IEnumerator Reset()
    {
        yield return new WaitForEndOfFrame();
        _isColliding = false;
    }

   
}
