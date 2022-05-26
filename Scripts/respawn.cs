
using UnityEngine;

public class respawn : MonoBehaviour
{
    private health playerHealth;
    public keys key;
    [SerializeField] private Transform START;
    [SerializeField] private AudioClip deathSound;
    private AudioSource source;

    private void Awake()
    {
        playerHealth = GetComponent<health>();
        source = GetComponent<AudioSource>();
        
    }

    public void Respawn()
    {
        transform.position = new Vector3(START.position.x, START.position.y, transform.position.z);
        source.PlayOneShot(deathSound);
    }
}
