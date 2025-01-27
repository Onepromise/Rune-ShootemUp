using UnityEngine;

public class RuneCollection : MonoBehaviour
{
    public float runeCollected = 0;

    public string runetag = "RuneOrb";
    public bool orbInside = false;
  

    //Reference to Scriptable Objects
    public SOPlayerStats playerStats;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(runetag) && !orbInside&&!playerStats.runeBackPackFull)
        {
            orbInside = true;
            runeCollected = runeCollected + 1;
        }
        else
        {
            orbInside = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(runetag))
        {
            orbInside = false;
        }
    }

    public float RuneCollectionToUI() 
    {
        return runeCollected;
    }
}