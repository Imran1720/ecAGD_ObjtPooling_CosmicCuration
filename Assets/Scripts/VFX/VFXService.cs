using System.Collections.Generic;
using UnityEngine;

namespace CosmicCuration.VFX
{
    public class VFXService
    {
        private List<VFXData> vfxData = new List<VFXData>();
        private VFXPool vFXPool;
        public VFXService(VFXView vfxView)
        {
            vFXPool = new VFXPool(vfxView);
        }

        public void PlayVFXAtPosition(VFXType type, Vector2 spawnPosition)
        {
            VFXController vfxToPlay = vFXPool.GetVFXController();
            vfxToPlay.Configure(type, spawnPosition);
        }

        public void ReturnVFXToPool(VFXController controller) => vFXPool.ReturnItem(controller);
    }
}