using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocktailCreator : MonoBehaviour
{
    public List<Ingridient> ingridients;

    public CocktailCreator(List<Ingridient> ingridients)
    {
        this.ingridients = ingridients;
    }

    public List<string> GetIngridientsNames()
    {
        var ingridientsNames = new List<string>();
        foreach (var item in ingridients)
        {
            ingridientsNames.Add(item.name);
        }
        return ingridientsNames;
    }
}

