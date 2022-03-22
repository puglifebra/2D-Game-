using UnityEngine;
using System.Collections.Generic; 
using UnityEngine.UI;
using System.Collections;

public class WavesSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;
    public List<Enemy> enemies = new List<Enemy>();
    public float timeBetweenWaves = 5f;
    private float countdown = 2f;
    public Text waveCountdownText;
    private int waveIndex = 1;
    public PlayerStats Stats;
    void Update ()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;

        }

        countdown -= Time.deltaTime;

        waveCountdownText.text = Mathf.Floor(countdown).ToString();
    }

    IEnumerator SpawnWave ()
    {
        Stats.GetMoney(enemies);
        for (int i = 0; i < waveIndex; i++)
        {
           SpawnEnemy(); 
           yield return new WaitForSeconds(0.5f);
        }
        
        waveIndex++;
    }

    void SpawnEnemy ()
    {
        enemies.Add(Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation).gameObject.GetComponent<Enemy>());
    }
}
