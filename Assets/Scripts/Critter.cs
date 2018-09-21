using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Critter : MonoBehaviour {

    public Vector2 LowerRange;
    public Vector2 upperRange;

    public Score scoreDisplay;

    public int pointValue = 1; // How much is this critter worth
    
    // Use this for initialization
	void Start () {

        transform.position = new Vector3(
            Random.Range(LowerRange.x, upperRange.x),
            Random.Range(LowerRange.y, upperRange.y),
            0
        );



	}
	
	// Update is called once per frame
	void Update () {
		

	}

    void OnMouseDown()
    {

        scoreDisplay.ChangeValue(pointValue);

        Destroy(gameObject);



    }









}
