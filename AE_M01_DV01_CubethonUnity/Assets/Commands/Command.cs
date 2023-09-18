using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public Rigidbody _player;
    public float timestamp; // for logging purposes
    public abstract void Execute();
}

class TurnLeft : Command
{
    private float _force;

    public TurnLeft(Rigidbody player, float force)
    {
        _player = player;
        _force = force;
    }

    public override void Execute()
    {
        timestamp = Time.timeSinceLevelLoad;
        _player.AddForce(-_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}

class TurnRight : Command
{
    private float _force;

    public TurnRight(Rigidbody player, float force)
    {
        _player = player;
        _force = force;
    }

    public override void Execute()
    {
        timestamp = Time.timeSinceLevelLoad;
        _player.AddForce(_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}