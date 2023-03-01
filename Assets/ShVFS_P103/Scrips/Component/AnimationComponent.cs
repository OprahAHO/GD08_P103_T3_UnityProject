using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationComponent : MonoBehaviour
{
    public InputComponentBase inputComponent;
    [SerializeField]
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(inputComponent.GetInputDirectionNormalized().magnitude > 0f)
        {
            animator.Play("Walk");


        }
        else
        {
            animator.Play("Idle");
        }
    }
}
