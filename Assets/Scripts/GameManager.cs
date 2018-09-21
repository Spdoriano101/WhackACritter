﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public List<GameObject> critterPrefabs;
    public float critterSpawnFrequency = 1.0f;
    public Score scoreDisplay; 

    private float lastCritterSpawn = 0; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Check if it is time to spawn the next critter 
        float nextSpawnTime = lastCritterSpawn + critterSpawnFrequency;
        if(Time.time >= lastCritterSpawn + critterSpawnFrequency)
        {
            // It is Time!!
            int critterIndex = Random.Range(0, critterPrefabs.Count);
            GameObject prefabToSpawn = critterPrefabs[critterIndex];

            // Spawn the critter!!
            GameObject spawnedCritter = Instantiate(prefabToSpawn);

            //Get access to our Critter script
            Critter critterScript = spawnedCritter.GetComponent<Critter>();

            //Tell the critter script the score object
            critterScript.scoreDisplay = scoreDisplay;

            //Update the most recent critter 
            lastCritterSpawn = Time.time;
        }
        
	}
}
