using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnerScript : MonoBehaviour
{
    public GameObject _bombPrefab;

    private float minX = -2.8f;
    private float maxX = 2.8f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBombs());
    }


    IEnumerator SpawnBombs()
    {
        yield return new WaitForSeconds(Random.Range(0f, 1f));
        Instantiate(_bombPrefab, new Vector2(Random.Range(minX, maxX), transform.position.y), quaternion.identity);

        StartCoroutine(SpawnBombs());

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
