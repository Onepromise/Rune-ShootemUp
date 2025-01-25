using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public LevelHQManager levelHQManager;
    public RuneCollection runeCollection;

    public string currentSceneName;


    void Awake() 
    {
        // Check if an instance already exists
        if (instance == null)
        {
            // If not, set this as the instance
            instance = this;

            // Make this GameObject persist across scene loads
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If an instance already exists, destroy this one. This prevents duplicates
            Destroy(gameObject);
            return; // Important to prevent further execution in this Awake method
        }

    }
    private void OnDestroy()
    {
        if (instance == this)
        {
            instance = null; // Clear the instance when the persistent object is destroyed (e.g., on application quit)
        }
    }



    private void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
    }



    private void Update()
    {
        LevelCompleted();
    }

    private void LevelCompleted()
    {
        if (currentSceneName == "HQMenu")
        {
            //
        }

    }

}
