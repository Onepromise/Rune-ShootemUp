using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoadHQ : MonoBehaviour
{
    public void LoadSceneByName()
    {
        SceneManager.LoadScene("HQMenu");
    }


    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            LoadSceneByName();
        }
    }
}
