using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller<PlayerInstaller>
{
    [SerializeField]
    private Player _player;
    public override void InstallBindings()
    {
        Container.BindInstance(_player);
        Container.BindInterfacesAndSelfTo<PlayerMove>().AsSingle();
    }
}