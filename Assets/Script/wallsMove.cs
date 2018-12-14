using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallsMove : MonoBehaviour {
    public float moveSpeed;
    public float minY;
    public float maxY;
    public float oldPosition;
    private GameObject obj;

	// Use this for initialization
	void Start () {
        obj = gameObject;
        oldPosition = 20;
        maxY = 1;
        minY = -2;
        moveSpeed = 3;
	}
	
	// Update is called once per frame
	void Update () {
        obj.transform.Translate(new Vector3(-1 * moveSpeed * Time.deltaTime, 0, 0));
	}
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag.Equals("ResetWall"))
        {
            obj.transform.position = new Vector3(oldPosition, Random.Range(minY, maxY - 1));
        }

    }
}
