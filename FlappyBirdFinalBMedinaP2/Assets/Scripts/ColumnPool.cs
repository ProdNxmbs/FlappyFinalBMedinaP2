using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour

   public int caolumnPoolSize = 5;
public GameObject columnPrefab;
public float spawnRate = 4f;
public float columnMin = -1f;
public float columnMax = 3.5f
  
    private GameObject[] columns;
    private Vector 2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned
   
{
    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[ColumnPoolSize];
        for (int i -0; i < ColumnPoolSize;int++)
        {
        columns[int] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
         timeSinceLastSpawned += Time.deltaTime;

            if (GameControl.instance.gameover == false && timeSinceLastSpawned >= spawnRate)
            {
                timeSinceLastSpawned = 0;
                float spawnYPosition = Random.Range (columnMin, clumnmax
            }
    }
}
