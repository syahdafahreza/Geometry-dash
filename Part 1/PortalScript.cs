using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public Gamemodes Gamemode;
    public Speeds Speed;
    public Gravity gravity;
    public int State;

    void OnCollisionEnter2D(Collision2D collision)
    {
        try
        {
            Movement movement = collision.GameObject.GetComponent<Movement>();

            movement.ChangeThroughPortal(Gamemode, Speed, gravity, State);
        }
        catch {}
    }
}