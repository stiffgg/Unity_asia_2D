using UnityEngine.SceneManagement;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public void gamestart()
    {
        print("start");
        SceneManager.LoadScene("Lv1");

    }

    public void quit ()
    {
        Debug.Log("quit");
        Application.Quit();

        
    }


}
