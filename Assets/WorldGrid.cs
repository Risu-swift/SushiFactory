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

    /// <summary>
    /// Given a position in the cell returns the center of that cell
    /// </summary>
    /// <param name="cellPosition"></param>
    /// <returns></returns>
    public Vector3 GetCellCenter(Vector3Int cellPosition)
    {
        return worldGrid.GetCellCenterWorld(cellPosition);
    }
    
    /// <summary>
    /// Given a world position returns the bottom left corner of the nearest cell
    /// </summary>
    /// <param name="position"></param>
    /// <returns></returns>
    [Button]
    public Vector3Int GetWorldGridPosition(Vector3 position)
    {
        return worldGrid.WorldToCell(position);
    }
}
