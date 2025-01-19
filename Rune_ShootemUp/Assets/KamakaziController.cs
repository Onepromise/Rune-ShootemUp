using UnityEngine;

public class KamakaziController : MonoBehaviour
{
   [SerializeField] private float speed = 5f;
 
 private Transform player;
 private Vector3 movementDirection;
 //public GameObject experienceOrb;
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
}
