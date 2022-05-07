 using Zenject;
using UnityEngine;

public class GreetingInstaller : MonoInstaller<GreetingInstaller>
{
   
    public override void InstallBindings()
    {
        Container.Bind<IGreeting>().To<Greeting>().AsSingle();
        //Container.BindInterfacesAndSelfTo<Greeting>().AsSingle(); //bind all interfaces from Greetins
        //Container.BindFactory<GreetingConsumer, GreetingConsumer.Factory>().FromComponentInNewPrefab(greetingPrefab);
    }
}
