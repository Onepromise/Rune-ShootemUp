using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    //Projectiles the player shoots
    public GameObject _projectilePrefab;
    public float projectileFireRate = 2.0f;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()   
    {
        //Shoot Timer
        if (timer < projectileFireRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            shootProjectile();
            timer = 0;

        }
    }

    public void shootProjectile()
    {
        Instantiate(_projectilePrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
    }

}
