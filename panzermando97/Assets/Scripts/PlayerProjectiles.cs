using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectiles : MonoBehaviour
{

    public GameObject faziDeath;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Enemy" ) {
            Instantiate(faziDeath, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "BoundaryRight") {
            Destroy(gameObject);
        }

                if (collision.gameObject.tag == "SolidRock") {
            Destroy(gameObject);
        }

        
    }
}