/*
 * Copyright 2019,2020 Sony Corporation
 */


using UnityEngine;
using SRD.Core;

namespace SRD.Utils
{
    internal class SRDCrosstalkCorrection
    {
        private bool _previousFrameActiveState;

        public void Init(ref bool isActive)
        {
            var handle = SRDSessionHandler.SessionHandle;
            SRDCorePlugin.SetActiveStateCrosstalkCorrection(handle, isActive);

            UpdateState(ref isActive);
        }

        public void HookUnityInspector(ref bool isActive)
        {
            ToggleActivateStateIfValueChanged(isActive);
            UpdateState(ref isActive);
        }

        private void ToggleActivateStateIfValueChanged(bool isActive)
        {
            if(_previousFrameActiveState != isActive)
            {
                var handle = SRDSessionHandler.SessionHandle;
                SRDCorePlugin.SetActiveStateCrosstalkCorrection(handle, isActive);
            }
        }

        private bool UpdateState(ref bool appState)
        {
            if(SRDProjectSettings.IsRunWithoutSRDisplayMode())
            {
                return true;
            }

            var handle = SRDSessionHandler.SessionHandle;
            var result = SRDCorePlugin.GetActiveStateCrosstalkCorrection(handle, out var pluginState);

            if(result != SrdXrResult.SUCCESS)
            {
                Debug.LogWarning(string.Format("Failed to set CrosstalkCorrection setting: {0}", result));
            }
            else if(appState != pluginState)
            {
                Debug.LogWarning("CrosstalkCorrection setting is not changed. Check your UserSettings.ini");
            }

            appState = _previousFrameActiveState = pluginState;
            return (result == SrdXrResult.SUCCESS);
        }
    }
}
