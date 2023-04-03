using UnityEngine;

public class CameraLerp_Script : MonoBehaviour {

    [HideInInspector]
    public Vector3 targetPos;
    private float smoothMovement = 1.2f;

    void Start() {
        targetPos = transform.position;
    } //-- Start function

    void Update() {
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothMovement * Time.deltaTime);
    } //-- Update function
}


/*

Made by : Rey M. Oronos, Jr.
Project : 

*/