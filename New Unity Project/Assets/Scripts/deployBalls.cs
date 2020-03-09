using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class deployBalls : MonoBehaviour {
    public GameObject ballsPrefab;
    public float respawnTime = 5.0f;
    private Vector2 screenBounds;
    public Text someballs;
    // Use this for initialization
    void Start () {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }
    private void spawnEnemy(){
        GameObject a = Instantiate(ballsPrefab) as GameObject; 
         a.GetComponent<balls>().scoreText= someballs;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x + 0.5f, screenBounds.x - 0.5f), screenBounds.y * 0.5f);
    }
    IEnumerator asteroidWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}