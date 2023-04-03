using UnityEngine;

public class Gameplay_Controller : MonoBehaviour {

    public static Gameplay_Controller instance;
    public BloxxSpawner_Script bloxx_Spawner;
    public CameraLerp_Script cameraLerp;

    private int moveCount;
    
    [HideInInspector]
    public Bloxx_Script currentBox;

    void Awake() {
        if(instance == null)
            instance = this;
    } //-- Awake function

    void Start() {
        bloxx_Spawner.SpawnBloxx();
    } //-- Start function

    void Update() {
        DetectInput();
    } //-- Update function

    void DetectInput() {
        if(Input.GetMouseButtonDown(0)) {
            currentBox.DropBox();
        }

    } //-- DetectInput function

} //-- End


/*

Made by : Rey M. Oronos, Jr.
Project : Color Bloxx

*/