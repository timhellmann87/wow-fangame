using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // List of enemies that spawn when player hits this collider, list needs to be filled in Inspector
	public List<SpawnEnemy> spawnEnemy = new List<SpawnEnemy>();
	private Collider boxCollider;

	private void Awake()
	{
		boxCollider = GetComponent<Collider>();
	}

	// Start is called before the first frame update
	void Start()
    {
		boxCollider.enabled = true;
		
		if ((spawnEnemy.Count != 0) && (spawnEnemy[0].enemy != null))
		{
			// Pool the enemy objects in the list
			foreach (SpawnEnemy enemyToSpawn in spawnEnemy)
			{
				Instantiate(enemyToSpawn.enemy);
				enemyToSpawn.enemy.SetActive(false);
			}
		}
		else
		{
			print("No enemies in list, nothing will be spawned");
		}
	}
	private void OnTriggerEnter(Collider other)
	{
		// Spawn enemies in list when player touches this collider, then deactivate the collider to not trigger it again. 
		if (other.CompareTag("Player"))
        {
            foreach(SpawnEnemy enemyToSpawn in spawnEnemy)
            {
                enemyToSpawn.enemy.transform.position = enemyToSpawn.startPosition;
                enemyToSpawn.enemy.SetActive(true);
			}

			boxCollider.enabled = false;
        }
	}
}

[Serializable]
public class SpawnEnemy
{
    public GameObject enemy;
    public Vector3 startPosition;
}
