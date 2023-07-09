using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProjectiles : MonoBehaviour
{
    public GameObject faziDeath;
    public float moveSpeed;
    private PointManagerscript pointManager;
    // Start is called before the first frame update
    void Start()
    {
     pointManager = GameObject.Find("PointManager").GetComponent<PointManagerscript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(faziDeath, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            pointManager.UpdateScore(50);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "BoundaryRight")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "SolidRock")
        {
            Destroy(gameObject);
        }
    }
}