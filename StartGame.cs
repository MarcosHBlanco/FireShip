using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartShooting(){
        SceneManager.LoadScene("SampleScene");
    }
}
