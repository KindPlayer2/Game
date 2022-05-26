
using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    private float currentHealth;
    private Animator anim;
    public bool dead;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        
        if(currentHealth == 0)
        {
            if(!dead)
            {
                anim.SetTrigger("die");
                GetComponent<playerMovement>().enabled = false;
                dead = true;

            }
            
        }
        
    }

    public void Respawn()
    {
        dead = false;
        currentHealth = 1;
        anim.ResetTrigger("die");
        anim.Play("idle");
        GetComponent<playerMovement>().enabled = true;
    }

}
