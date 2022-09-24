using Infrastructure;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Infrastructure.Services
{
    public class StaticDataService : IService
    {
        private const string GhostDataPath = "Ghost/TypesSO";

        private Dictionary<string, GhostDataSO> _ghosts;

        public void Load()
        {
            _ghosts = Resources
            .LoadAll<GhostDataSO>(GhostDataPath)
            .ToDictionary(x => x.name, x => x);
        }

        public GhostDataSO GetRandomGhost()
        {
            return ForMonster(_ghosts.ElementAt(Random.Range(0, _ghosts.Count)).Key);
        }

        public GhostDataSO ForMonster(string name) =>
         _ghosts.TryGetValue(name, out GhostDataSO staticData)
          ? staticData
          : null;

    }
}