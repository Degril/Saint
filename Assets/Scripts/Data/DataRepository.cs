using System.Collections.Generic;
using System.Linq;
using Configs.Scriptables;
using Data.Configs;
using Data.ResourceData;
using Gameplay;
using UnityEngine;

public static class DataRepository
{
    private static readonly List<BuildingData> _buildingsData;
    public static IReadOnlyList<BuildingData> BuildingsData => _buildingsData;
    
    private static readonly Dictionary<ResourceName, MovableObject> _resourceModels;
    public static IReadOnlyDictionary<ResourceName, MovableObject> ResourceModels => _resourceModels;

    static DataRepository()
    {
        _buildingsData = Resources.Load<BuildingsConfig>("Buildings/BuildingConfig").buildingsData;
        _resourceModels = Resources.LoadAll<ResourceConfig>("ResourceItems")
            .ToDictionary(resource => resource.resourceName, resource => resource.resourceModel);
    }
}
