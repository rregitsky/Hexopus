using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Initialize map
        // Procedurally generate?
        // Partial init?
        createPath();
        // Initialize UI elements
        // Initialize entities	
	}
	
	// Update is called once per frame
	void Update () {
		// Move UI elements
        // Move entities
        // Move map position
            // Generate next portion of map?
	}

    private void createPath() {
        PointPath path = new PointPath(Vector2.right, Vector2.up, .5f, 2f);
        List<GameObject> objs = new List<GameObject>();
        path.addPoint(new Vector2(-10f, -5f));
        path.addRandomPoints(10);
        foreach(Vector2 point in path.getPoints()) {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obj.transform.position = point;
            obj.transform.localScale = new Vector3(.1f, .1f, .1f);
            objs.Add(obj);
        }
    }
}
