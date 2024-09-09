using UnityEngine;

namespace UnityServiceLocator
{
	// <summary>
	/// This script is automatically called on startup and if the necessary managers are found in the Resources folder,
	/// it instantiates them.
	// </summary>
	public static class ServiceLocatorLoader
	{
		private const string ServiceLoaderPath = "gitament-ServiceLocatorGlobal";
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void Initialize()
		{
			var serviceLoader = Resources.Load<GameObject>(ServiceLoaderPath);
			if(serviceLoader) Object.Instantiate(serviceLoader);
		}
	}
}