using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float speed;
    public ScoreScript scoreScript;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a") && transform.position.x > -7.3)
        {
            Vector3 move = new Vector3(-1f, 0f, 0f);
            transform.position += move * Time.deltaTime * speed;

        }
        if (Input.GetKey("d") && transform.position.x < 5.5)
        {
            Vector3 move = new Vector3(+1f, 0f, 0f);
            transform.position += move * Time.deltaTime * speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            Debug.Log("You Have Been Hit");
            scoreScript.UpdatePlayerLives(-1);
    }
    
}
