using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody2D rb;
    public float startSpeed; //velocidade da bola
    public Vector2[] startDiretion; //lista de direções
    public AudioSource ballSound;

    // Start is called before the first frame update
    void Start()
    {
        //lista de direções aleaórias
        int selectedStartDirection = Random.Range(0, 3);
        rb.velocity = startDiretion[selectedStartDirection] * startSpeed;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("leftBar")&& !collision.gameObject.CompareTag("rightBar"))
        {
            ballSound.Play();
        }

        if (collision.gameObject.CompareTag("leftBar"))
        {
            GameObject.FindAnyObjectByType<gameController>().AddScore(false);
        }

        if (collision.gameObject.CompareTag("rightBar"))
        {
            GameObject.FindAnyObjectByType<gameController>().AddScore(true);
        }

    }
}