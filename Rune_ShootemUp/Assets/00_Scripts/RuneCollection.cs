using UnityEngine;

public class RuneCollection : MonoBehaviour
{
    public float runeCollected = 0;

    public string runetag = "RuneOrb";
    public bool orbInside = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(runetag) && !orbInside)
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
        Debug.Log("I left!");
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