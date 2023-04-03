using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameplay_Controller : MonoBehaviour {

    public static Gameplay_Controller instance;
    public BloxxSpawner_Script bloxx_Spawner;
    public Gameplay_UI _gameplayUI;

    public CameraLerp_Script cameraLerp;

    private int lerpCount;
    [HideInInspector]
    public int bloxxCount = 0;
    
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
            currentBox.DropBloxx();
        }

    } //-- DetectInput function

    public void SpawnNewBloxx() {
        Invoke("NewBloxx", 1.2f);
    } //-- SpawnNewBloxx function

    void NewBloxx() {
        bloxx_Spawner.SpawnBloxx();
    } //-- NewBloxx function

    public void LerpCamera() {
        lerpCount++;
        
        if(lerpCount == 1) {
            lerpCount = 0;
            cameraLerp.targetPos.y += 1.2f;
        }
    } //-- LerpCamera function

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    } //-- RestartGame function

    public void ReturnHome() {
        SceneManager.LoadScene("Home");
    } //-- ReturnHome function

    public void BloxxScore() {
        bloxxCount++;
        _gameplayUI.UpdateScore(bloxxCount);
    } //-- BloxxScore function
    
    public void ShowGameOverVE() {
        _gameplayUI.GameOverVE();
    } //-- ShowGameOverVE

} //-- End


/*

Made by : Rey M. Oronos, Jr.
Project : Color Bloxx

*/