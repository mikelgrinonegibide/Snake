

using UnityEngine;

public class AutoSnake : Snake
{
    public Vector2 FoodPosition { get; set; }


    // Update is called once per frame
    void Update()
    {
        CalculateDirection1();
    }

    private Vector2Int CalculateDirection1()
    {
        //Obtiene la distancia de la cabeza a la comida
        var distance = this.FoodPosition - new Vector2(this.transform.position.x, this.transform.position.y);

        //Decidir si va en vertical u horizontal

        //Obtiene que direccion esta mas lejana
        if (Mathf.Abs(distance.x) <= Mathf.Abs(distance.y))
        {

        }



    }

}
