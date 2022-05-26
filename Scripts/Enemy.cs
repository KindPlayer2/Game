
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]private float damage;
    
    private void OnTriggerEnter2D(Collider2D collsion)
    {
        if(collsion.tag == "Player")
        {
            collsion.GetComponent<health>().TakeDamage(damage);
        }
    }
}
