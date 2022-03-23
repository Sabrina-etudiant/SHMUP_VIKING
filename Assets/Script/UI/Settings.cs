using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public void onSettings()
    {
        SceneManager.LoadScene("Settings");
    }
}
