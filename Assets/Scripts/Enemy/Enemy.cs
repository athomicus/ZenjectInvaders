 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{
    [SerializeField]
    private AnimationCurve xCurve;
    [SerializeField]
    private AnimationCurve yCurve;
   
    [SerializeField]
    private Transform enemyStartTransform;

   private Vector3 enemyInitialPosition;  
    public float yHeightEnemy = 2.0f;
    public float speed = 0.5f;
    private float direction = 1;

    [Inject]
    public void Construct()
    {
         
    }
    

    
    private Rigidbody rBody;
    private float timeElapsed = 0;
    
    
    void Awake()
    {
       rBody = GetComponent<Rigidbody>();
       enemyInitialPosition =  enemyStartTransform.position;
       transform.position = enemyInitialPosition;
    }
 
    void FixedUpdate()
    {         
        timeElapsed += Time.deltaTime * speed;  
        if(timeElapsed>1.0f)  
        {
            timeElapsed = 0;
            direction *= -1;
            enemyInitialPosition = transform.position;
             
        }

        var enemyMirrorPosition = Mathf.Abs(enemyInitialPosition.x * 2.0f); 
        Vector3 e_position = new Vector3(
            enemyInitialPosition.x + direction * xCurve.Evaluate(timeElapsed) * enemyMirrorPosition, 
            enemyInitialPosition.y + yCurve.Evaluate(timeElapsed) * yHeightEnemy,
            0);
        rBody.MovePosition(e_position);         
    }

   public class EnemyFactory : PlaceholderFactory<Enemy>{}


}
