using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float moveSpeed =1;
    public float vInput;
    Animator myAnimator;
    public GameManagerScript gameManager;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
        vInput = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector2.up * moveSpeed * vInput * Time.deltaTime);
   
    }

    
        
        private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.tag == "EnemyProjectile" || collision.gameObject.tag == "Enemy" ) {
            myAnimator.SetTrigger("Hit");
            Debug.Log("lost");
            gameManager.gameOver();
        }


    
}
}