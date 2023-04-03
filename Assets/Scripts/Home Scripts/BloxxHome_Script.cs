using UnityEngine;

public class BloxxHome_Script : MonoBehaviour {

    private Rigidbody2D myBody;
    private SpriteRenderer spriteRend;

    void Awake() {
        myBody = GetComponent<Rigidbody2D>();
        myBody.gravityScale = Random.Range(2.0f, 4.0f);

        Color randColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        spriteRend = GetComponent<SpriteRenderer>();
        spriteRend.color = randColor;
    } //-- Awake function

    void OnTriggerEnter2D(Collider2D target) {
        if(target.tag == "GameOver") {
            Destroy(gameObject);
        }
    } //-- OnTriggerEnter2D function
}


/*

Made by : Rey M. Oronos, Jr.
Project : 

*/