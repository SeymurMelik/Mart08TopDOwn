using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _speed = 5f;

    private void Update()
    {
        CharacterRun();
    }
    void CharacterRun()
    {
        Vector2 direction = new Vector2( Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}
