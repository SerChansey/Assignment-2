using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private LayerMask _groundLayerMask;

    [SerializeField]
    private float _speed;
    
    [SerializeField]
    public float _jumpForce;
    
    
    private Rigidbody2D _rBody;
    private CapsuleCollider2D _cap2D;
    
    private bool _isJumping;

    void Start()
    {
       _rBody = GetComponent<Rigidbody2D>();
       _cap2D = GetComponent<CapsuleCollider2D>();
        
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _rBody.velocity = new Vector2(_speed, _rBody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
            
        }

        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

            _rBody.velocity = new Vector2(-_speed, _rBody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
            
        }
        


        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            _rBody.velocity = new Vector2(_rBody.velocity.x, _jumpForce);
        
        }
        
        if (IsGrounded() && _isJumping==true)
        {
            _isJumping = false;
        }
        if(IsGrounded() == false && _isJumping == false)
        {
            _isJumping = true;
        }
      
    }
   
 
    private bool IsGrounded() {
        float extraHeight = 0.2f;
        RaycastHit2D groundCastHit = Physics2D.BoxCast(_cap2D.bounds.center, _cap2D.bounds.size, 0f, Vector2.down, extraHeight, _groundLayerMask);

        return groundCastHit.collider != null;

    }
   
    
}
