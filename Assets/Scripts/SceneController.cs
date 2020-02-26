using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject character;
    private CharacterController characterController;
    
    private void Awake() 
    {
        characterController = character.GetComponent<CharacterController>();
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            characterController.SetTrigger("Crouch");           
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            characterController.SetTrigger("OnGround");
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            characterController.SetParameter("Turn", 2.5f);
        }
          if(Input.GetKeyDown(KeyCode.V))
        {
            characterController.SetParameter("Forward", 2.5f);
        }
    }
}
