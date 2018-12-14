using UnityEngine;

public class backGrourdMove : MonoBehaviour {
    public float moveSpeed;
    public float moveRanger;
    private Vector3 oldPosition;
    private GameObject obj;
	// Use this for initialization
	void Start () {
        obj = gameObject;
        moveSpeed = 3;
        moveRanger = 32;
        oldPosition = obj.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed, transform.position.y, 0));
        if(Vector3.Distance(oldPosition, obj.transform.position)>moveRanger)
        {
            obj.transform.position = oldPosition;
        }
	}
}
