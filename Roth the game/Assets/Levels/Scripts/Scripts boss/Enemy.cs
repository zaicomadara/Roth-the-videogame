using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string EnemyName;//nombre del enemigo
    public float healthPoints;// cantidad de puntos de vida
    public float speed; // velocidad al caminar
    public float KnockbackForceX;//fuerza que se aplicara horizontalmente al recibir un golpe
    public float KnockbackForceY;//fuerza que se aplicara verticalmente al recibir un golpe
    public float damageToGive;// daño que hara el jugador
}
