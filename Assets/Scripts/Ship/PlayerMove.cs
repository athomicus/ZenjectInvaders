using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerMove : ITickable
{
     private Player _player;
     private float _speed = 1f;

     private Vector3 _startPosition =new Vector3(0,0,0);

     public PlayerMove( Player player )
     {
          _player = player;    
     }

     public void Tick() 
     {
          _player.transform.Translate(_player.transform.right * _speed * Time.deltaTime);
 
     }
}
