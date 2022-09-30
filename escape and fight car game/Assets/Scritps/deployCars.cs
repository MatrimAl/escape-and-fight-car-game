using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployCars : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject carsPrefab;
    public GameObject motorsPrefab;
    public GameObject coinPrefab;
    public GameObject peelPrefab;
    public float respawnTime = 8.0f;
    public float respawnTime2 = 8.0f;
    public float respawnTime3 = 8.0f;
    public float respawnTimePeel = 8.0f;
    public float respawnTimeEnemy = 8.0f;
    void Start()
    {
        StartCoroutine(motorsWave());
        StartCoroutine(carsWave());
        StartCoroutine(coinWave());
        StartCoroutine(peelWave());
        StartCoroutine(enemyWave());
    }
    private void spawnCars()
    {
        GameObject a = Instantiate(carsPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-14, 13), 55);
    }
    private void spawnMotor()
    {
        GameObject b = Instantiate(motorsPrefab) as GameObject;
        b.transform.position = new Vector2(Random.Range(-14, 13), 55);
    }
    
    private void spawnCoin()
    {
        GameObject c = Instantiate(coinPrefab) as GameObject;
        c.transform.position = new Vector2(Random.Range(-14, 13), 55);
    }
    private void spawnPeel()
    {
        GameObject d = Instantiate(peelPrefab) as GameObject;
        d.transform.position = new Vector2(Random.Range(-14, 13), 55);
    }
    
    private void spawnEnemy()
    {
        GameObject e = Instantiate(enemyPrefab) as GameObject;
        e.transform.position = new Vector2(-1, -38);
    }

    IEnumerator enemyWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTimeEnemy);
            spawnEnemy();
        }
    }
    IEnumerator peelWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTimePeel);
            spawnPeel();
        }
    }
    IEnumerator carsWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnCars();
        }
    }
    IEnumerator motorsWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime2);
            spawnMotor();
        }
    }
    IEnumerator coinWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime3);
            spawnCoin();
        }
    }

}
