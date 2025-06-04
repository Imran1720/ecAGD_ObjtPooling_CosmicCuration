using CosmicCuration.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool
{
    private EnemyView enemyPrefab;
    private EnemyScriptableObject enemyScriptableObject;
    private List<PooledEnemy> pooledEnemiesList = new List<PooledEnemy>();
    public EnemyPool(EnemyView enemyPrefab, EnemyScriptableObject enemyScriptableObject)
    {
        this.enemyPrefab = enemyPrefab;
        this.enemyScriptableObject = enemyScriptableObject;
    }

    public EnemyController GetEnemy()
    {
        if (pooledEnemiesList.Count > 0)
        {
            PooledEnemy pooledEnemy = pooledEnemiesList.Find(item => !item.isUsed);
            if (pooledEnemy != null)
            {
                pooledEnemy.isUsed = true;
                return pooledEnemy.Enemy;
            }
        }

        return CreatePooledEnemy();

    }

    private EnemyController CreatePooledEnemy()
    {
        PooledEnemy pooledEnemy = new PooledEnemy();
        pooledEnemy.Enemy = new EnemyController(enemyPrefab, enemyScriptableObject.enemyData);
        pooledEnemy.isUsed = true;
        pooledEnemiesList.Add(pooledEnemy);

        return pooledEnemy.Enemy;
    }

    public void ReturnEnemyToPool(EnemyController enemyController)
    {
        PooledEnemy pooledEnemy = pooledEnemiesList.Find(item => item.Enemy.Equals(enemyController));
        pooledEnemy.isUsed = false;
    }
    private class PooledEnemy
    {
        public EnemyController Enemy;
        public bool isUsed;
    }

}
