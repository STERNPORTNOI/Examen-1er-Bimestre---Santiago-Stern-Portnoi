using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicMarket : MonoBehaviour
{
    // Start is called before the first frame update

    public string Producto1;
    public float PrecioProducto1;
    public int UnidadesProducto1;

    public string Producto2;
    public float PrecioProducto2;
    public int UnidadesProducto2;

    public string Producto3;
    public float PrecioProducto3;
    public int UnidadesProducto3;


    void Start()
    {
        float precioP1 = PrecioProducto1 * UnidadesProducto1;
        float precioP2 = PrecioProducto2 * UnidadesProducto2;
        float precioP3 = PrecioProducto3 * UnidadesProducto3;

        float precioDescuento1 = 0;
        float precioDescuento2 = 0;
        float precioDescuento3 = 0;

        float descuento1 = 0;
        float descuento2 = 0;
        float descuento3 = 0;

        float monto = precioP1 + precioP2 + precioP3;
        float montoConDescuento = precioDescuento1 + precioDescuento2 + precioDescuento3;
        float descuentos = descuento1 + descuento2 + descuento3;

        if (PrecioProducto1 < 1 || PrecioProducto2 < 1 || PrecioProducto3 < 1)
        {
            Debug.Log("El precio de cualquier producto no puede ser menor a 1");
        }

        else if (UnidadesProducto1 < 1 || UnidadesProducto2 < 1 || UnidadesProducto3 < 1)
        {
            Debug.Log("Las unidades de cualquier producto no puede ser menor a 1");
        }

        else
        {
            if (UnidadesProducto1 > 3 || UnidadesProducto2 > 3 || UnidadesProducto3 > 3)
            {
                if (UnidadesProducto1 > 3)
                {
                    precioDescuento1 = precioP1 % 5;
                    descuento1 = precioP1 - precioDescuento1;
                }

                else
                {
                    precioDescuento1 = precioP1;
                }

                if (UnidadesProducto2 > 3)
                {
                    precioDescuento2 = precioP2 % 5;
                    descuento2 = precioP2 - precioDescuento2;
                }

                else
                {
                    precioDescuento2 = precioP2;
                }

                if (UnidadesProducto3 > 3)
                {
                    precioDescuento3 = precioP3 % 5;
                    descuento3 = precioP3 - precioDescuento3;
                }

                else
                {
                    precioDescuento3 = precioP3;
                }

                Debug.Log("El monto total sin descuentos es $" + monto + ". El monto de los descuentos aplicados es $" + descuentos + ". El monto con los descuentos aplicados es $" + montoConDescuento);
            }

            else
            {
                montoConDescuento = monto;

                Debug.Log("El monto total es de $" + monto + ". No se aplicó ningún descuento y por eso el monto de los descuentos es 0 y el monto con los decuentos aplicados es con descuento es $" + monto); 
            } 

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
