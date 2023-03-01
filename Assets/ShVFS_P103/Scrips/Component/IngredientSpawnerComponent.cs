using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientSpawnerComponent : InteractableComponentBase
{
    [SerializeField] FoodComponent spawnFood;
    public override void Interact(FoodComponent food,Transform pos)
    {
        Debug.Log("Spawn the food");
        var cloneFood=Instantiate(spawnFood,structurePos);
        //Give food to pos
        cloneFood.gameObject.transform.SetParent(pos,false);
        
    }
}

