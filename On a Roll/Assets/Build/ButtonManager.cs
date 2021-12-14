using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private string S_LevelA;
    [SerializeField] private string S_LevelB;
    [SerializeField] private string S_LevelC;
    [SerializeField] private string S_LevelD;

    public void LoadLevelA()
    {
        SceneManager.LoadScene(S_LevelA);
    }

    public void LoadLevelB()
    {
        SceneManager.LoadScene(S_LevelB);
    }

    public void LoadLevelC()
    {
        SceneManager.LoadScene(S_LevelC);
    }
    public void LoadLevelD()
    {
        SceneManager.LoadScene(S_LevelD);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}