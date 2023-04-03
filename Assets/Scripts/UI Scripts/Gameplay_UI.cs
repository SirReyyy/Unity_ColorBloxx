using UnityEngine;
using UnityEngine.UIElements;

public class Gameplay_UI : MonoBehaviour {
    
    public Gameplay_Controller _gameplayController;
    public VisualElement veGameplay, veRestart;
    public Label lblBloxxScore, lblFinalScore;
    public Button btnRestart, btnHome;
    [HideInInspector]
    public int scoreCount;

    void OnEnable() {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        // Gameplay VE
        veGameplay = root.Q<VisualElement>("VE_Gameplay");
        lblBloxxScore = root.Q<Label>("Lbl_ScoreCount");

        // Restart VE
        veRestart = root.Q<VisualElement>("VE_Restart");
        lblFinalScore = root.Q<Label>("Lbl_Score");
        btnRestart = root.Q<Button>("Btn_Restart");
        btnHome = root.Q<Button>("Btn_Home");

        // Button functions
        btnRestart.clicked += () => GameRestart();
        btnHome.clicked += () => GameHome();

        // Initial VE States
        veGameplay.style.display = DisplayStyle.Flex;
        veRestart.style.display = DisplayStyle.None;
    } //-- OnEnable function

    public void UpdateScore(int num) {
        scoreCount = num;
        lblBloxxScore.text = scoreCount.ToString();
        lblFinalScore.text = scoreCount.ToString();
    }

    public void GameOverVE() {
        veGameplay.style.display = DisplayStyle.None;
        veRestart.style.display = DisplayStyle.Flex;
    } //-- GameOverVE function

    void GameRestart() {
        _gameplayController.RestartGame();
    } //-- GameRestart function

    void GameHome() {
        _gameplayController.ReturnHome();
    } //-- GameHome function
}


/*

Made by : Rey M. Oronos, Jr.
Project : Code Bloxx

*/