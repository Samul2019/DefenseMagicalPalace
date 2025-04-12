using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elements : MonoBehaviour
{
    public enum TipoElemento
    {
        Aire,
        Agua,
        Tierra,
        Fuego
    }

    // Usar el enum como tipo de la propiedad
    public TipoElemento tipoElemento;

    // Si necesitas un string para otras partes del código
    public string tipoElementoString
    {
        get { return tipoElemento.ToString(); }
    }
}
