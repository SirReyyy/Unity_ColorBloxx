using UnityEngine;
using UnityEngine.SceneManagement;

public class Home_Controller : MonoBehaviour {

    public BloxxSpawnerHome_Script bloxxSpawner_Home;

    private float instanceDelay = 1.0f;
    private float time = 0.0f;
    private float interpolationPeriod = 0.5f;

    void Update() {
        time += Time.deltaTime;
 
        if (time >= interpolationPeriod) {
            time = time - interpolationPeriod;
            SpawnNewHomeBloxx();
        }
 
    } //-- Update function

    public void SpawnNewHomeBloxx() {
        Invoke("NewHomeBloxx", instanceDelay);
    } //-- SpawnNewHomeBloxx function

    void NewHomeBloxx() {
        bloxxSpawner_Home.SpawnHomeBloxx();
    } //-- NewBloxx function

    public void PlayGame() {
        SceneManager.LoadScene("Gameplay");
    }
} //-- End


/*

Made by : Rey M. Oronos, Jr.
Project : Color Bloxx

*/