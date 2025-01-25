using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelHQManager : MonoBehaviour
{
    public GameManager gameManager;
    public string sceneName;
    public static float levelRune;

    //Menu Items
    public GameObject menuItems;
    public Slider HQRuneContainerSlider;
    public float HQRuneAmount;
    public float HQRuneMax;
    public TMP_Text HQruneTotalText;

    //Level Menu Items
    public GameObject levelMenu;
    public TMP_Text levelText;
    public TMP_Text playButtonText;

    //Upgrade Menu Items
    public GameObject upgradeMenu;
    

    public GameObject Quit;

    
    public void Start() 
    {
        OnMenuItemsButtonClick();
        //HQRuneAmount +;
        
    }


    public void Update()
    {
        HQRuneContainerSlider.value = HQRuneAmount;
        HQruneTotalText.text = HQRuneAmount.ToString();
    }

    public void OnLevelButtonClick()
    {
        menuItems.SetActive(false);
        upgradeMenu.SetActive(false);
        levelMenu.SetActive(true);
    }
    public void OnMenuItemsButtonClick()
    { 
        menuItems.SetActive(true); 
        levelMenu.SetActive(false);
        upgradeMenu.SetActive(false);
        
    }
    public void OnUpgradeButtonClick()
    {
        menuItems.SetActive(false);
        levelMenu.SetActive(false);
        upgradeMenu.SetActive(true);

    }

    public void OnTestLevelButtonClick()
    {

        levelText.text = "The Test Level is the basic starting level, with basic enemies!";
        playButtonText.text = "Load Test Level!";
        sceneName = "TestLevel";
        

    }

    public void OnLevel1ButtonClick() 
    {
        levelText.text = "Level 1 is a bit more challenging with a new enemy introduced!";
        playButtonText.text = "Load Level 1!";
        sceneName = "Level1";
    }

    public void OnExitGameButton()
    {
        QuitGame();
    }
    void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // For exiting play mode in the editor
        #else
            Application.Quit(); // For exiting the built application
        #endif
    }


    public void LoadSceneByName()
    {
        SceneManager.LoadScene(sceneName); // Loads a scene by its name
    }
}
