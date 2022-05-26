using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;
    [SerializeField] private AudioClip KeySound;
    [SerializeField] private AudioClip JumpSound;
    [SerializeField] private AudioClip deathSound;
    private Rigidbody2D body;
    private Animator anim;
    private BoxCollider2D boxCollider;   
    private float wallJumpCooldown;
    private float horizontalInput;
    public int counter = 0;
    private AudioSource source;


    private void Awake()
    {
        //grab reference from in unity functions
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        //flip right when player walks right
        if(horizontalInput > 0.01f)
            transform.localScale = new Vector3(0.45f, 0.45f, 0.8f);

        //flip left when player walks left
        if(horizontalInput < -0.01f)
            transform.localScale = new Vector3(-0.45f, 0.45f, 0.8f);


        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded", isGrounded());

        if(isGrounded())
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if(wallJumpCooldown > 0.2f)
        {
            body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

            if(onWall() && !isGrounded())
            {
            }
            else
                body.gravityScale = 5;

            //jump button
            if(Input.GetKey(KeyCode.Space))
                Jump();

        }
        else
            wallJumpCooldown += Time.deltaTime;
    }

    private void Jump()
    {
        if(isGrounded())
        {
            body.velocity = new Vector2(body.velocity.x + 2, jumpPower);
            source.PlayOneShot(JumpSound);
            anim.SetTrigger("jump");
        }
        else if(onWall()  && !isGrounded())
        {
            if(horizontalInput == 0)
            {
            }
            else            	
                body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 3, 6);
                
            wallJumpCooldown = 0;
        }
    }

    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center,boxCollider.bounds.size,0,Vector2.down,0.1f,groundLayer);
        return raycastHit.collider != null;
    }

    private bool onWall()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center,boxCollider.bounds.size,0,new Vector2(transform.localScale.x,0),0.1f,wallLayer);
        return raycastHit.collider != null;
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "key")
        {
            counter = counter + 1;
            source.PlayOneShot(KeySound);
        }
    }
    
}
