using UnityEngine;

public class SpawninWorld : MonoBehaviour
{
    public GameObject spawnObject;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        InputManager.OnMouseClicked += SpawnAtCell;
        
    }

    private void SpawnAtCell(Vector3 obj)
    {
        //Convert to world space
        Ray r = Camera.main.ScreenPointToRay(obj);
        RaycastHit hit;

        if (Physics.Raycast(r, out hit))
        {
            var cellPos = WorldGrid.instance.GetWorldGridPosition(hit.point);
            var cellCenter =  WorldGrid.instance.GetCellCenter(cellPos);
            //cellCenter.y += 1;
            Instantiate(spawnObject, cellCenter, Quaternion.identity);
            
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
