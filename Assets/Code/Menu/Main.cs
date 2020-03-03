using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    public void Exit()
    {
        Application.Quit();
    }

    public void Awake()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }
    public void PlayNewGame()
    {
        SceneManager.LoadScene("LoadScene");
        Cursor.visible = false;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Scenes/LoadScene");
        Cursor.visible = false;
    }
}
