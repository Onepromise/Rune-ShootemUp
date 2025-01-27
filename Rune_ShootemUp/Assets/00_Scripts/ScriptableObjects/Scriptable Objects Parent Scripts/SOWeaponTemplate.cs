using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName ="New Weapon", menuName ="Weapons,New Weapon")]
public class SOWeaponTemplate : ScriptableObject
{
    public float fireRate;
    public float fireSpeed;
    public Sprite itemIcon;
    public GameObject mesh;
    public float damage;
    public elementCategory element;
   
}
public enum elementCategory
{
    None,
    Fire,
    Water,
    Earth,
    Air
}
