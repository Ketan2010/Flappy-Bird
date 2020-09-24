using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void quit()
    {
        Application.Quit();
    }
    
}
