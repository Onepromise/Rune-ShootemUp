using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;


    private static float HQTotalRunePower;
    private static float HQCurrentRunePower;


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

}
