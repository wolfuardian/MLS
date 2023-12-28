#region

using UnityEngine;
using Zenject;

#endregion

namespace Eos.UI.Main
{
    public class UIInstaller : MonoInstaller
    {
        #region Public Methods

        public override void InstallBindings()
        {
            Container.BindInterfacesTo<UIInitializer>().AsSingle();
        }

        #endregion
    }
}