using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Infrastructure.Services
{
    public class AssetProvider : IService
    {
        public GameObject Instantiate(string path, Vector3 at)
        {
            var prefab = Resources.Load<GameObject>(path);
            return Object.Instantiate(prefab, at, Quaternion.identity);
        }

        public GameObject Instantiate(string path)
        {
            var prefab = Resources.Load<GameObject>(path);
            return Object.Instantiate(prefab);
        }

        internal GameObject Instantiate(object targetUIPath)
        {
            throw new System.NotImplementedException();
        }
    }
}