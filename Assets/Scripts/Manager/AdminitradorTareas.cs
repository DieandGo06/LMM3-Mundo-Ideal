using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


/* Logica
 * Guarda una serie de acciones/metodos en una lista y los ejecuta pasado un tiempo/timer, tras ello, los saca de la lista.
 * 
 * Agregue un metodo para que puediera ejecutar un funcion durante "x" tiempo antes de sacarlo de la lista.
 * 
 * Si se ejecuta en un update sin condiciones tipo "GetKeyDown", se crea una tarea por cada por frame, imitando a un update normal.
 */



//Este codigo es sacado de: https://www.youtube.com/watch?v=OGyp3jAmpnw&list=PLJ2Wt5mAxvQWQmMED-lc3BcPh5q9RE_p6&index=33&t=5s
public class AdminitradorTareas : MonoBehaviour
{

    void Update()
    {
        foreach (Tareas.Tarea _tarea in Tareas.listaTareas) {
            if (Time.time > _tarea.momentoInicio) {
                if (_tarea.accion != null) {
                    _tarea.accion();
                }
                if (_tarea.accion_string != null) {
                    _tarea.accion_string(_tarea.texto);
                }
                if (_tarea.accion_int != null) {
                    _tarea.accion_int(_tarea.numeroInt);
                }
                Tareas.listaTareas.Remove(_tarea);
                break;
            }
        }
    }


}


public static class Tareas
{
    public class Tarea
    {
        public float momentoInicio;
        public float duracion;
        public Action accion;

        public Action<string> accion_string;
        public Action<int> accion_int;
        public string texto;
        public int numeroInt;
    }

    public static List<Tarea> listaTareas = new List<Tarea>();

    public static void Nueva(float _timer, Action _accion)
    {
        listaTareas.Add(new Tarea {
            momentoInicio = Time.time + _timer,
            accion = _accion
        });
    }

    public static void Nueva(float _timer, Action<string> _accion, string _texto)
    {
        listaTareas.Add(new Tarea {
            momentoInicio = Time.time + _timer,
            accion_string = _accion,
            texto = _texto
        });
    }

    public static void Nueva(float _timer, Action<int> _accion, int _numero)
    {
        listaTareas.Add(new Tarea {
            momentoInicio = Time.time + _timer,
            accion_int = _accion,
            numeroInt = _numero
        });
    }




    public static void NuevaConDuracion(float _momentoInicio, float _duracion, Action _accion)
    {
        listaTareas.Add(new Tarea {
            momentoInicio = Time.time + _momentoInicio,
            duracion = _duracion,
            accion = _accion
        });
    }



}