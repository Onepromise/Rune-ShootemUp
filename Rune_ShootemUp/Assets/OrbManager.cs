using UnityEngine;

public class OrbManager : MonoBehaviour
{
    private float _rotationSpeed = 30;
    private float lifeTime = 3f;
    private float startTime;

    void Start()
    {
        //Records the time when the object was created
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //Life cycle of Rune Orbs
        transform.Rotate(0,_rotationSpeed * Time.deltaTime, 0);
        if(Time.time - startTime >= lifeTime)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }    
    }
}
