using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnTourist : MonoBehaviour
{
    [SerializeField] private GameObject _tourist;
    private Vector3[] _spawnPositionTourist = new[]
    {
        new Vector3(-1.14f, 7.4f, 14.24f),
        new Vector3(2.51f, 7.4f, 14.24f),
        new Vector3(-2.58f,8.43f,11.95f)
    };

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<SpawnBoats>())
        {
            Vector3 pos = _spawnPositionTourist[Random.Range(0, _spawnPositionTourist.Length)];
            Instantiate(_tourist,pos,Quaternion.identity);
        }
    }
}

