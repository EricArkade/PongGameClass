using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    public bool _isPlayerOne;
    private bool _isPressingUp;
    private bool _isPressingDown;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Its a kind of magic");
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.zero; 
        if (_isPlayerOne) 
        {
            _isPressingUp = Input.GetKey(KeyCode.W);
            _isPressingDown = Input.GetKey(KeyCode.S);
        }
        else
        {
            _isPressingUp = Input.GetKey(KeyCode.UpArrow);
            _isPressingDown = Input.GetKey(KeyCode.DownArrow);
        }


        if (_isPressingUp)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (_isPressingDown)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}
