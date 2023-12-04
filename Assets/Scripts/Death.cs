using UnityEngine;

public sealed class Death : MonoBehaviour
{
    private Animator _animator;
    private MoveTourist _moveTourist;
    private MoveTourist MoveTourist => _moveTourist ??= GetComponent<MoveTourist>();
    private Animator Anim => _animator ??= GetComponent<Animator>();
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<MovePlayer>())
        {
            Anim.SetBool("Death",true);
            MoveTourist.enabled = false;
            Destroy(gameObject,1f);
            FindObjectOfType<Rigidbody>().drag = 10f;
        }
    }
}
