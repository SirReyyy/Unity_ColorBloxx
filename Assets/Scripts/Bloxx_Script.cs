using UnityEngine;

public class Bloxx_Script : MonoBehaviour {
    
    private float min_X = -2.2f, max_X = 2.2f;
    private bool canMove;
    private float moveSpeed = 2.0f;
    private Rigidbody2D myBody;

    private bool gameOver;
    private bool ignoreCollision;
    private bool ignoreTrigger;

    
    void Awake() {
        myBody = GetComponent<Rigidbody2D>();
        myBody.gravityScale = 0.0f;
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

    public void DropBox() {
        canMove = false;
        myBody.gravityScale = Random.Range(2,4);

    } //-- DropBox function

} //-- End


/*

Made by : Rey M. Oronos, Jr.
Project : Color Bloxx

*/