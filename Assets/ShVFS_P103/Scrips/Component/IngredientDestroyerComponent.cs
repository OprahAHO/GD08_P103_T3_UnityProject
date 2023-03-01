using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientDestroyerComponent : InteractableComponentBase
{
    public override void Interact(FoodComponent food, Transform pos)
    {
        Debug.Log("Destroy the food");
        Destroy(food.gameObject);
    }
}
