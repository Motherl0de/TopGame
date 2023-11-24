using UnityEngine;

public class SpawnTourist : MonoBehaviour
{
    [SerializeField] private GameObject _tourist;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<SpawnBoats>())
        {
            
        }
    }
}
