using UnityEngine.SceneManagement;
using UnityEngine;

public class startgame : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

   
}
