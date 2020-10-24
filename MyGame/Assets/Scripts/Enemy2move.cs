using UnityEngine;

public class Enemy2move : Enemies2
{

    //variables
    public int _moveSpeed;
    public int _attackDamage;
    public int _lifePoints;
    public float _attackRadius;
    public Animator animator;
    //movement
    public float _followRadius;
    //end
    [SerializeField] Transform playerTransform;
 
    SpriteRenderer enemySR;
    float horizontalMove = 0f;
    void Start()
    {

         animator = playerTransform.gameObject.GetComponent<Animator>();
        //get the player transform   
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
        //enemy animation and sprite renderer 
   
        enemySR = GetComponent<SpriteRenderer>();
        //set the variables
        setMoveSpeed(_moveSpeed);
        setAttackDamage(_attackDamage);
        setLifePoints(_lifePoints);
        setAttackRadius(_attackRadius);
        setFollowRadius(_followRadius);
    }

    // Update is called once per frame
    void Update()
    {


        //
        horizontalMove = Input.GetAxisRaw("Horizontal") * Mathf.Abs(_moveSpeed);
         animator.SetFloat("Speed", Mathf.Abs(horizontalMove));



      //  if ((Mathf.Abs(playerTransform.position.x - transform.position.x) > 2)) // if the player is not moving 
       //     animator.SetBool("Walking", true);

        if (checkFollowRadius(playerTransform.position.x, transform.position.x))
        {

           
            //if player in front of the enemies
            if (playerTransform.position.x < transform.position.x )
            {

                if (checkAttackRadius(playerTransform.position.x, transform.position.x))
                {
                    //for attack animation
             
                }
                else
                {

                    if (playerTransform.position.x < transform.position.x && (playerTransform.position.x) - (transform.position.x) < 3)
                        this.transform.position += new Vector3(-getMoveSpeed() * Time.deltaTime, 0f, 0f);  // moving left
                                                                                                      //for attack animation

                    //walk
                     enemySR.flipX = true; //flips e
                }

            }
            //if player is behind enemies
            else if ((playerTransform.position.x > transform.position.x ) && (playerTransform.position.x) - (transform.position.x) > 3) //
            {

                
                if (checkAttackRadius(playerTransform.position.x, transform.position.x))
                {
                    //for attack animation
                   
                }
                else
                {
                    this.transform.position += new Vector3(getMoveSpeed() * Time.deltaTime, 0f, 0f); // moving right
                    //for attack animation
                 
                    //walk
                 
                    enemySR.flipX = false;
                }


            }
        }
        else
        {
          
        }


    }
}