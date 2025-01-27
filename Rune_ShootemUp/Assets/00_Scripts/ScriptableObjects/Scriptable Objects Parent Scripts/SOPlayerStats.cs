using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName = "PlayerStats")]
public class SOPlayerStats : ScriptableObject
{
    public float currentHealth;
    public float maxHealth;
    public float speed;
    public float fireRate;
    public float damage;

    public bool runeBackPackFull;
    public float runeCollected;
}
