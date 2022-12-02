using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] fruits;
    public GameObject bomb;

    public float xBounds, yBounds;

    // Start is called before the first frame update
    void Start(){
        StartCoroutine(SpawnGO());
    }

    IEnumerator SpawnGO(){
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomFruta = Random.Range(0, fruits.Length);

        if (Random.value <= 0.6f){
            Instantiate(fruits[randomFruta], new Vector2(Random.Range(-xBounds, xBounds), yBounds), Quaternion.identity);
        }
        else{
            Instantiate(bomb, new Vector2(Random.Range(-xBounds, xBounds), yBounds), Quaternion.identity);
        }

        StartCoroutine(SpawnGO());
    }    
}
