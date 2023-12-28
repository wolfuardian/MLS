#region

using UnityEngine;
using UnityEngine.UI;
using Zenject;

#endregion

namespace Eos.UI.Main
{
    public class UIInitializer : IInitializable
    {
        #region Public Variables
        [Inject(Id = "SYSTEM_INFO_VERSION")] public readonly Text SystemInfoVersion;
        
        #endregion


        #region Public Methods

        public void Initialize()
        {
            Debug.Log("UIInitializer.Initialize()");
            SystemInfoVersion.text = Application.version;
        }

        #endregion
    }
}