using UnityEngine;

public class KamakaziController : MonoBehaviour
{
   [SerializeField] private float speed = 5f;
 
 private Transform player;
 private Vector3 movementDirection;
 public GameObject runeOrb;
 //private bool _experinceDropped;

 void Start()
 {
     player = GameObject.FindWithTag("Player").transform;
     speed = Random.Range(1f,5f);
 }

 private void Update()
 {
     EnemyMovement();    
 }

 private void EnemyMovement()
 {
     Vector3 direction = (player.position - transform.position).normalized;
     Vector3 movement = direction * speed * Time.deltaTime;
     transform.Translate(movement);
 }

private void OnTriggerEnter(Collider other) 
 {
    if(other.CompareTag("Player"))
    {
        Destroy(gameObject);
        Instantiate(runeOrb, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(-23,25,51));
    }   
 }

}
