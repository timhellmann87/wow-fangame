using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector]
	public GameObject gameManager;

    public enum PlayerClass {Human, Orc, Draenei, Tauren};
    public PlayerClass playerClass; 

    [HideInInspector]
    public Vector3 playerStartPosition;

    [HideInInspector]
    public int currentHP, maxHP;

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

    public void PickUpItem()
    {

    }

}
