

using System;
using System.Collections.Generic;

public class GenericObjectPool<T> where T : class
{

    private List<PooledItem<T>> pooledItemsList = new List<PooledItem<T>>();

    public T GetItem()
    {
        if (pooledItemsList.Count > 0)
        {
            PooledItem<T> pooledItem = pooledItemsList.Find(item => !item.isUsed);
            if (pooledItem != null)
            {
                pooledItem.isUsed = true;
                return pooledItem.Item;
            }
        }

        return CreateNewPooledItem();
    }

    private T CreateNewPooledItem()
    {
        PooledItem<T> newPooledItem = new PooledItem<T>();
        newPooledItem.Item = CreateItem();
        newPooledItem.isUsed = true;

        pooledItemsList.Add(newPooledItem);

        return newPooledItem.Item;
    }

    protected virtual T CreateItem()
    {
        throw new NotImplementedException("Child not Implemented CreateItem()");
    }

    public class PooledItem<T>
    {
        public T Item;
        public bool isUsed;
    }
}
