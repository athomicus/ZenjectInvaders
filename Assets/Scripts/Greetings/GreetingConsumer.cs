using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GreetingConsumer : MonoBehaviour
{ 
    //interface IGreeting( wcześniej był zbindowany z klasą Greeting) jest tu wstrzykiwany 
             //klasa GreetingComsumer nie musi wiedzieć nic o aktualnej implementacji, nie musi tworzyć nowego obiektu
             //dynamicznych obiektów nei da sie w ten sposób  w zenject spawnić( instantiate) trzeba mieć Factory

    [Inject] 
    private IGreeting greeting;
 

   public float timeBetweenMessage = 1f;
   private float timeSinceMessage = 0;
    
    void Update()
    {
        timeSinceMessage += Time.deltaTime;
        if(timeSinceMessage > timeBetweenMessage)
        {
            Debug.Log(greeting.Message);
            timeSinceMessage = 0;
        }
    }
}


 

public interface IGreeting
{
    string Message {get;}
}

public class Greeting : IGreeting
{
    private string _message = "Hello World";
    public string Message
    {
        get
        {
            return _message;
        }
    }
}
