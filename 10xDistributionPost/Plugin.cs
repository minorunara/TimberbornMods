using BepInEx;
using BepInEx.Logging;
using Bindito.Core;
using Timberborn.AssetSystem;
using Timberborn.SingletonSystem;
using TimberbornAPI;
using TimberbornAPI.AssetLoaderSystem.AssetSystem;
using TimberbornAPI.Common;
using UnityEngine;



namespace Timberborn10xDistributionPost
{
    [BepInPlugin(PluginGuid, "10xDistribution", PluginVersion)]
    [BepInDependency("com.timberapi.timberapi")]
    public class Plugin : BaseUnityPlugin
    {
        public const string PluginGuid = "minorunara.Timberborn.10xDistribution";
        public const string PluginVersion = "1.0.0";

        public static ManualLogSource Log;

        private void Awake()
        {
            Log = Logger;

            TimberAPI.AssetRegistry.AddSceneAssets(PluginGuid, SceneEntryPoint.Global);

            TimberAPI.DependencyRegistry.AddConfiguratorBeforeLoad(new BuildingAddConfigurator(), SceneEntryPoint.MainMenu);

            Log.LogInfo($"Loaded {PluginGuid} {PluginVersion}!");
        }
    }

    public class BuildingAdd : ILoadableSingleton
    {
        private readonly IAssetLoader _assetLoader;
        private readonly IResourceAssetLoader _resourceAssetLoader;

        public BuildingAdd(IAssetLoader assetLoader, IResourceAssetLoader resourceAssetLoader)
        {
            _assetLoader = assetLoader;
            _resourceAssetLoader = resourceAssetLoader;
        }

        public void Load()
        {
            var platformModel = _resourceAssetLoader.Load<GameObject>("Buildings/Paths/Platform/Platform.Full.Folktails");
            var shader = platformModel.GetComponent<MeshRenderer>().materials[0].shader;

            AddBuilding("10xDistributionPost.FT", shader);
            AddBuilding("10xDistributionPost.IT", shader);

            Plugin.Log.LogInfo($"Loaded buildings!");
        }

        private void AddBuilding(string name, Shader shader)
        {
            var building = _assetLoader.Load<GameObject>(Plugin.PluginGuid, $"distributionpost.bundle/{name}");

            FixMaterialShader(building, shader);
        }

        private static void FixMaterialShader(GameObject obj, Shader shader)
        {
            var meshRenderer = obj.GetComponent<MeshRenderer>();
            if (meshRenderer)
            {
                foreach (var mat in meshRenderer.materials)
                {
                    mat.shader = shader;
                }
            }

            foreach (Transform child in obj.transform)
            {
                if (child.gameObject)
                {
                    FixMaterialShader(child.gameObject, shader);
                }
            }
        }
    }

    public class BuildingAddConfigurator : IConfigurator
    {
        public void Configure(IContainerDefinition containerDefinition)
        {
            containerDefinition.Bind<BuildingAdd>().AsSingleton();
        }
    }
}
