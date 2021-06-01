using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    Button newGameBtn;

    Button continueBtn;

    Button quitBtn;


    PlayableDirector director;
    private void Awake()
    {
        newGameBtn = transform.GetChild(1).GetComponent<Button>();

        continueBtn = transform.GetChild(2).GetComponent<Button>();

        quitBtn = transform.GetChild(3).GetComponent<Button>();

        quitBtn.onClick.AddListener(QuitGame);
        continueBtn.onClick.AddListener(ContinueGame);
        newGameBtn.onClick.AddListener(PlayTimeline);

        director = FindObjectOfType<PlayableDirector>();
        //director.stopped += NewGame;
    }

    void PlayTimeline()
    {
        // director.Play();
        PlayerPrefs.DeleteAll();
        SceneController.Instance.TransitionToFirstLevel();
    }


    void NewGame(PlayableDirector director)
    {
        PlayerPrefs.DeleteAll();
        SceneController.Instance.TransitionToFirstLevel();

    }

    void ContinueGame()
    {
        SceneController.Instance.TransitionToLoadGame();
    }
    void QuitGame()
    {
        Application.Quit();
    }
}
