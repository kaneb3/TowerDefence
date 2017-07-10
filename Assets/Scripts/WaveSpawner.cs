using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform SpawnPoint;
    public Transform enemyPrefab;
    public float TimeBetweenWaves = 5f;

    public Text WaveCoudntownText;
    private float countdown = 2f;

    private int wavenumber = 0;

    void Update()

    {
        if (countdown <= 0)
        {
            StartCoroutine(Spawnwave());
            countdown = TimeBetweenWaves;

        }
        countdown -= Time.deltaTime;

        WaveCoudntownText.text = Mathf.Round(countdown).ToString();

    }

    IEnumerator Spawnwave()
    {
        wavenumber++;
        for (int i = 0; i < wavenumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.3f);
             
        }
       
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, SpawnPoint.position, SpawnPoint.rotation);
    }
	
}
