using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static int _deathCounter = 0;
    [SerializeField]
    private GameObject _deathText;

    public static int _treasureCounter = 0;
    [SerializeField]
    private GameObject _treasureText;

    public static int _time;
    [SerializeField]
    private GameObject _timerText;
    public bool _stopTime = true;

    private static GameController _instance;
    public Vector2 _lastRespawn;
    public GameObject _player;
    void Start()
    {
        StartCoroutine("Timer");
    }
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(_instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            _time += 1;
        }
    }
    public void Update()
    {
        _treasureText.GetComponent<Text>().text = "Treasure:" + _treasureCounter;
        _deathText.GetComponent<Text>().text = "Deaths:" + _deathCounter;
        _timerText.GetComponent<Text>().text = "Time:" + _time;
    }
}
