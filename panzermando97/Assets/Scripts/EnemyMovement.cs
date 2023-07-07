using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeedx =1;
    public float moveSpeedy =1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

         transform.Translate(Vector2.left * moveSpeedx * Time.deltaTime);
         transform.Translate(Vector2.up * moveSpeedy * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.tag == "Boundary" || collision.gameObject.tag == "SolidRock" ) {
            moveSpeedy *= -1;
        }

    }
}
