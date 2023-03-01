using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class InteractorComponent : MonoBehaviour
{
    // Start is called before the first frame update
    private float interactMultiplier;
    private PlayerActions playerActions;
    [SerializeField]
    private float movementSpeed = 5;
    [SerializeField]
    private float playerWidth;
    [SerializeField]
    private float playerHeight;
    [SerializeField] Transform pos;
    private float interactDistance => interactMultiplier* Time.deltaTime;
    private void Awake()
    {
        playerActions = new PlayerActions();
        playerActions.PlayerInput.Enable();
    }

    // Update is called once per frame
    private void Update()
    {
        
        if (playerActions.PlayerInput.InteractPrimary.WasPressedThisFrame())
        {
            Debug.Log("E");

            TryInteract();
        }
    }
    private void TryInteract()
    {
        var hits = Physics.CapsuleCastAll(transform.position, transform.position + Vector3.up * playerHeight, playerWidth, transform.forward, interactDistance);

        if (hits.Length < 1) return;

        //if (!hits.All(hit => hit.transform.GetComponent<InteractableComponentBase>() == null))

        FoodComponent food = GetComponentInChildren<FoodComponent>();

        foreach (var hit in hits)
        {
            var interactable = hit.transform.GetComponent<InteractableComponentBase>();
            if(interactable == null) return;
            interactable.Interact(food,pos);
        }
    }
}
