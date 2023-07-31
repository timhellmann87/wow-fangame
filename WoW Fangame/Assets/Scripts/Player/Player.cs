using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector]
	public GameObject gameManager;

    public enum PlayerClass {HumanHuntress, OrcShaman, DraeneiDK, TaurenWarrior};
    public PlayerClass playerClass; 

    [HideInInspector]
    public Vector3 playerStartPosition;

	public int coins;

	[HideInInspector]
    public int currentHP, maxHP;
	public int currentMP, maxMP;

	//RPG Stats
	[HideInInspector]
    public int attack, defense;

    private float moveSpeed;

    // Sprites and armor piece holders
    private GameObject playerSprite;
    public GameObject helmetHolder;
    public GameObject shoulderHolder;
    public GameObject bodyArmorHolder;
    public GameObject bootsHolder;

    
    void Awake()
    {


    }

    // Start is called before the first frame update
    void Start()
    {
       
        // Set Base Values depending on choice of class
        switch (playerClass)
        {

            case PlayerClass.HumanHuntress:
                break;
            case PlayerClass.OrcShaman:
                break;
            case PlayerClass.DraeneiDK:
                break;
            case PlayerClass.TaurenWarrior: 
                break;
        }

        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack()
    {

    }

    public void Block()
    {

    }

    public void Move(){

    }

	public void Jump()
	{

	}

	public void PickUpItem()
    {

    }

}
