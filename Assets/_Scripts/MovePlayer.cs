using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    private CharacterController characterController; // Correction ici

    private float playerSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 characterMove = new Vector3(0, 0, -Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime);
        characterController.Move(characterMove); // Correction ici
    }
}
