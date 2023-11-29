using UnityEngine;

public sealed class Death : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<MovePlayer>())
        {
            GetComponent<MoveTourist>().enabled = false;
            Destroy(gameObject,1.5f);
        }
    }
}
