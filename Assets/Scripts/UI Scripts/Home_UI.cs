using UnityEngine;
using UnityEngine.UIElements;

public class Home_UI : MonoBehaviour {

    public Home_Controller _homeController;
    public VisualElement veHome;
    public Button btnPlay;


    void OnEnable() {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        // Home Container
        veHome = root.Q<VisualElement>("VE_Home");
        btnPlay = root.Q<Button>("Btn_Play");

        // Button Function
        btnPlay.clicked += () => PlayGame();
    } //-- OnEnable function

    void PlayGame() {
        _homeController.PlayGame();
    }

} //-- End


/*

Made by : Rey M. Oronos, Jr.
Project : Color Bloxx

*/