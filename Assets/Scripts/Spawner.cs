using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;


public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _boat;

    private Vector3[] _pos = new[]
    {
        new Vector3(-8.9f, 5.42f, 69.8f),
        new Vector3(40.7f, 5.42f, 33.2f),
        new Vector3(91.1f,5.42f,-24.7f),
        new Vector3(3.7f,5.42f,-69.8f),
        new Vector3(-63.6f,5.42f,1.4f)
    };

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        int count = 0;
        while (count < 10)
        {
            yield return new WaitForSeconds(10f);
            Vector3 position = _pos[Random.Range(0, _pos.Length)];
            Instantiate(_boat, position,Quaternion.identity);
        }
    }
}
