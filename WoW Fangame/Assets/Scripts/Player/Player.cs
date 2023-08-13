using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector]
	public GameObject gameManager;

    [HideInInspector]
    public Vector3 playerStartPosition;

	public int coins;

	[HideInInspector]
    public int currentHP, maxHP;
	public int currentMP, maxMP;

	//RPG Stats
	[HideInInspector]
    public int attack, defense;

    //private float moveSpeed;

    // Sprites and armor piece holders
    private GameObject playerSprite;
    public GameObject helmetHolder;
    public GameObject shoulderHolder;
    public GameObject bodyArmorHolder;
    public GameObject bootsHolder;

    // Second input attempt
    [SerializeField]
    private float maxMoveSpeed;
	[SerializeField]
	private float startSpeed, curSpeed;
	[SerializeField]
	private float jumpForce;

    private NewControls newControls;
    private Rigidbody2D rb2D;
    private Vector2 moveInput;
    private float moveSpeed;

    private bool isGrounded;
    private bool isWalking;
    private bool isInvincible;
    private bool isAttacking;
    private bool isBlocking;
    private bool isJumping;
    
    void Awake()
    {
        newControls = new NewControls();
        rb2D = GetComponent<Rigidbody2D>(); 
        if (rb2D is null)
        {
            Debug.Log("RB2D is NULL");
        }

        // Set start speed
        startSpeed = 0.5f;
        curSpeed = startSpeed;
    }

	// Enable Action Map for Player Controls
	private void OnEnable()
	{
        newControls.PlayerActionMap.Enable();
	}

	private void OnDisable()
	{
		newControls.PlayerActionMap.Disable();
	}

	// Start is called before the first frame update
	void Start()
    {
        // Assign player sprite child automatically
        playerSprite = transform.GetChild(0).gameObject;

        currentHP = maxHP;

        // DUMMY
        isGrounded = true;

	}

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
		// Player movement
		moveInput = newControls.PlayerActionMap.MovePlayer.ReadValue<Vector2>();

		if (moveInput.x == 0)
        {
            curSpeed = startSpeed;
		}
        else
        {
			// Exponential speed increasing
			if (curSpeed < maxMoveSpeed)
				curSpeed += Time.deltaTime * 5;  // 3 for soft increment, 5 for fast increment
			else
				curSpeed = maxMoveSpeed;

			moveInput.y = 0;
            rb2D.velocity = new Vector2 (moveInput.x * curSpeed, rb2D.velocity.y);
        }

        // Sprite direction 
		if (moveInput.x < -0.1f)
		{
            playerSprite.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (moveInput.x > 0.1f)
		{
			playerSprite.transform.localScale = new Vector3(-1f, 1f, 1f);
		}

        // Fallkurve
		if (rb2D.velocity.y < 0)
		{
			rb2D.velocity += Vector2.up * Physics2D.gravity.y * (1.5f - 1) * Time.deltaTime;
		}
	}

    public void Attack()
    {

    }

    public void Block()
    {

    }

    public void BlockEnd()
    {

    }

	public void Jump()
	{
        print("Jump");

		rb2D.AddForce(new Vector2(0, jumpForce));
	}

	public void Grab()
	{

	}

	public void PickUpItem()
    {

    }

}
