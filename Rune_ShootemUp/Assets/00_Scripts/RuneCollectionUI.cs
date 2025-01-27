using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RuneCollectionUI : MonoBehaviour
{
    public Slider runePowerSlider;
    public float runeCollected = 0f;
    public float runeMaxCapacity = 20f;
    public float runeMinCapacity = 0f;
    

    public RuneCollection runeCollection;


    //Teleporter data
    public GameObject teleporter;
    public TMP_Text teleporterTextIncoming;
    public float teleporterWarningPercent;
    public float teleporterSpawnerPercent;

    //reference ScriptableObjects
    public SOPlayerStats playerStats;



    private void Start()
    {
        runePowerSlider.minValue = runeMinCapacity;
        runePowerSlider.maxValue = runeMaxCapacity;
        runePowerSlider.value = runeCollected;
        teleporterWarningPercent = runeMaxCapacity / 2;
        teleporterSpawnerPercent = (runeMaxCapacity / 2) + (runeMaxCapacity / 4);
        teleporter.SetActive(false);

        playerStats.runeBackPackFull = false;
        

    }

    private void Update()
    {
        RuneCollectionMath();
        TeleporterMath();
        //stores rune Collection per level
        
    }

    private void RuneCollectionMath()
    {

        if (runeCollected <= runeMaxCapacity)
        {
            runeCollected = runeCollection.RuneCollectionToUI();
            runeCollected = runeCollection.runeCollected;
            runePowerSlider.value = runeCollected;
            playerStats.runeCollected = runeCollected;
        }
        else 
        {
            playerStats.runeCollected = runeMaxCapacity;
            playerStats.runeBackPackFull = true;
        }
    }


    private void TeleporterMath()
    {
        if (teleporterWarningPercent <= runeCollected)
        {
            teleporterTextIncoming.gameObject.SetActive(true);
            
        }
        else
        {
            teleporterTextIncoming.gameObject.SetActive(false);
        }


        if (teleporterSpawnerPercent  <= runeCollected)
        {
            teleporterTextIncoming.text = "Teleporter is active!";
            teleporter.SetActive(true);
        }
    }
}
