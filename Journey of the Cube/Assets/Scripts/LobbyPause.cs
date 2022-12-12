using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LobbyPause : MonoBehaviour
{
    public Button pauseButton;
    public static bool isgamePaused = false;

    [SerializeField] GameObject pauseMenu;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
            if (isgamePaused)
            {
                ResumeGame();
            }
            else 
            {
                PauseGame();        
            }
    }

    public void PauseButtonClick()
    {
        if (isgamePaused)
            {
                ResumeGame();
            }
            else 
            {
                PauseGame();        
            }
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isgamePaused = false;
        pauseButton.interactable = true;
    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isgamePaused = true;
        pauseButton.interactable = false;
    }

    public void LogOutMenu()
    {   
        Time.timeScale = 1f;
        pauseButton.interactable = true;
        SceneManager.LoadScene(1);
    }

    public void QuitMenu()
    {
        Application.Quit();
        Debug.Log("Quit, oyun kapandı.");
    }
}
