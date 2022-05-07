
using UnityEngine;
using Zenject;

public class EnemyInstaller : MonoInstaller
{

    public GameObject enemyPrefab;
    public override void InstallBindings()
    {
        
        Container.BindFactory<Enemy,Enemy.EnemyFactory>().FromComponentInNewPrefab(enemyPrefab);
    }
}
