using UnityEngine;
using UnityEngine.Serialization;

public sealed class Camera : MonoBehaviour
{
    [FormerlySerializedAs("_cameraFollow")] [SerializeField] private GameObject _player;
    [SerializeField]private Health _health;
    

    private void Update()
    {
        if (_health.currentHP <= 0)
        {
            if (transform.position.z <= -120f) {
                //Вызвать меню
                return;
            }
            
            Destroy(_player);
            transform.Translate(Vector3.back * 5f * Time.deltaTime);
        }
    }
}
