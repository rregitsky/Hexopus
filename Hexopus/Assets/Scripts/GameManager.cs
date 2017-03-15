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
        List<MapPieceObject> mapPieces = new List<MapPieceObject>();
        mapPieces.Add(new MapPieceObject());
        foreach(MapPieceObject mapPiece in mapPieces)
        {
            mapPiece.render();
        }
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
}
