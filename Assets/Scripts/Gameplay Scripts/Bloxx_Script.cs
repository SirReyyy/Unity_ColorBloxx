using UnityEngine;

public class Bloxx_Script : MonoBehaviour {
    
    private float min_X = -2.2f, max_X = 2.2f;
    private bool canMove;
    private float moveSpeed = 2.0f;
    private Rigidbody2D myBody;
    private SpriteRenderer spriteRend;

    private bool gameOver;
    private bool ignoreCollision;
    private bool ignoreTrigger;

    
    void Awake() {
        myBody = GetComponent<Rigidbody2D>();
        myBody.gravityScale = 0.0f;

        Color randColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        spriteRend = GetComponent<SpriteRenderer>();
        spriteRend.color = randColor;
    } //-- Awake function

    void Start() {
        canMove = true;

        if(Random.Range(0,2) > 0) {
            moveSpeed *= -1.0f;
        }

        Gameplay_Controller.instance.currentBox = this;
    } //-- Start function

    void Update() {
        MoveBox();
    } //-- Update function

    void MoveBox() {
        if(canMove) {
            Vector3 temp = transform.position;
            temp.x += moveSpeed * Time.deltaTime;

            if(temp.x > max_X) {
                moveSpeed *= -1.0f;
            } else if(temp.x < min_X) {
                moveSpeed *= -1.0f;
            }

            transform.position = temp;
        }

    } //-- MoveBox function

    public void DropBloxx() {
        canMove = false;
        myBody.gravityScale = Random.Range(2,4);

    } //-- DropBox function

    void BloxxLanded() {
        if(gameOver)
            return;

        ignoreCollision = true;
        ignoreTrigger = true;

        Gameplay_Controller.instance.BloxxScore();
        Gameplay_Controller.instance.SpawnNewBloxx();
        Gameplay_Controller.instance.LerpCamera();
    } //-- BloxxLanded function

    void RestartGame() {
        Gameplay_Controller.instance.RestartGame();
    } //-- RestartGame function

    void OnCollisionEnter2D(Collision2D target) {
        if(ignoreCollision)
            return;
        
        if(target.gameObject.tag == "Platform" || target.gameObject.tag == "Bloxx") {

            Invoke("BloxxLanded", 2.0f);
            ignoreCollision = true;
        }
    } //-- OnCollisionEnter2D function

    void OnTriggerEnter2D(Collider2D target) {
        if(ignoreTrigger)
            return;
        
        if(target.tag == "GameOver") {
            CancelInvoke("BloxxLanded");
            gameOver = true;
            ignoreTrigger = true;

            Invoke("RestartGame", 2.0f);
        }
    } //-- OnTriggerEnter2D function

} //-- End


/*

Made by : Rey M. Oronos, Jr.
Project : Color Bloxx

*/