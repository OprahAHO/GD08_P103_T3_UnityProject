using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientSpawnerComponent : InteractableComponentBase
{
    [SerializeField] 
    FoodComponent spawnFood;
    private FoodComponent ownFood;
    public override void Interact(FoodComponent food,Transform pos)
    {
        var ingredient = Instantiate(spawnFood);
        Debug.Log("Spawn the food");
        if (ownFood == null)
        {
            ownFood = Instantiate(spawnFood, structurePos);
        }

        else
        {
            //Give food to pos
            ownFood.gameObject.transform.SetParent(pos, false);
        }

    }
}

