using System.Collections.Generic;
using Data.Configs;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Configs.Scriptables
{
    [CreateAssetMenu(fileName = nameof(BuildingsConfig), menuName = "Data/" + nameof(BuildingsConfig))]
    public class BuildingsConfig : SerializedScriptableObject
    {
        [ShowInInspector] public List<BuildingData> buildingsData;
    }
}