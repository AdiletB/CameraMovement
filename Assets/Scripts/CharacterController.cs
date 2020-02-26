using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator animator;
    private void Awake() => animator = GetComponent<Animator>();
    public void SetTrigger(string name)
    {
        if(animator.GetBool(name))
            animator.ResetTrigger(name); 
        else
            animator.SetTrigger(name);
    }
    public void SetParameter(string name, float value)
    {
        if(animator.GetFloat(name) > 0f)
            animator.SetFloat(name, 0f);
        else
            animator.SetFloat(name, value);
        
    }
}
