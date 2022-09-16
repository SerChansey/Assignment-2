using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject _objectToFollow ;
    [SerializeField]
    float _speed = 2.0f;

    
    void Update()
    {
        
            float interpolation = _speed * Time.deltaTime;

            Vector3 position = this.transform.position;
            position.y = Mathf.Lerp(this.transform.position.y, _objectToFollow.transform.position.y, interpolation);
            position.x = Mathf.Lerp(this.transform.position.x, _objectToFollow.transform.position.x, interpolation);

            this.transform.position = position;
        
    }
}
