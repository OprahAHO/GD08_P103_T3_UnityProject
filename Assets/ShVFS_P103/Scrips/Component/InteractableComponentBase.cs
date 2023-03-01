using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class InteractableComponentBase : MonoBehaviour
{
    [SerializeField]
    public Transform structurePos;
    public abstract void Interact(FoodComponent food,Transform pos);
    public IngredientConfiguration configuration;
    /*public TextMesh */
}
