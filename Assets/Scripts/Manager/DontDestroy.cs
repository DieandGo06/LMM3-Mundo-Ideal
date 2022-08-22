using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    #region Que hace...
    /* Los objetos que contengan este script no se destruiran al cargar una nueva escena
     * y si la nueva escena ya contiene este objeto, se destruira la nueva instancia. */
    #endregion

    #region Limitaciones
    /* Todos los objetos que contegan este script deben tener nombres distintos, sino se duplicaran */
    #endregion


    private void Start()
    {
        //Busco todos los objetos que contegan este script
        DontDestroy[] noDestruibles = FindObjectsOfType<DontDestroy>();

        for (int i=0; i < noDestruibles.Length; i++)
        {
            //Comprueba que el script no se este buscando asi mismo porque tendria el mismo nombre
            if (noDestruibles[i] != this)
            {
                //Si el objeto esta duplicado, se destruye el nuevo
                if (noDestruibles[i].gameObject.name == gameObject.name)
                {
                    Destroy(gameObject);
                }
            }
        }
        //Evita que se destruya al cambiar de escena
        DontDestroyOnLoad(gameObject);
    }
}
