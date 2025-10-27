using System;
using Sirenix.OdinInspector;
using UnityEngine;

public class WorldGrid : MonoBehaviour
{
    public Grid worldGrid;

    public static WorldGrid instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else 
            Destroy(gameObject);
            
        worldGrid = GetComponent<Grid>();
        
    }

    public Vector3 GetCellCenter(Vector3Int cellPosition)
    {
        return worldGrid.GetCellCenterWorld(cellPosition);
    }
    
    [Button]
    public Vector3Int GetWorldGridPosition(Vector3 position)
    {
        return worldGrid.WorldToCell(position);
    }
}
