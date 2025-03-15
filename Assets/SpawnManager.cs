using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Enemy;

    void Start()
    {
        InvokeRepeating("MakeEnemy", 0, 0.3f);
    }

    void MakeEnemy()
    {
        Instantiate(Enemy, new Vector3(Random.Range(-9f, 9f), 6, 0), Quaternion.identity);
    }
}
