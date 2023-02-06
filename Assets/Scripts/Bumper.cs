using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _animator.SetTrigger("AnimBumper");
        collision.rigidbody.AddForce(-collision.contacts[0].normal * 5, ForceMode2D.Impulse);
    }
}
