using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class RemoveSoil : MonoBehaviour
{

    public Grid grid;
    public Tilemap Tilemap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var cellPosition = grid.WorldToCell(transform.position);
            var tile = Tilemap.GetTile(cellPosition);
            Tilemap.SetTile(cellPosition, null);
        }
    }
}
