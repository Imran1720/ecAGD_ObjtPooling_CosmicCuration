using System.Collections.Generic;
using UnityEngine;

namespace CosmicCuration.VFX
{
    public class VFXView : MonoBehaviour
    {
        private VFXController controller;


        [SerializeField] private List<VFXData> particleData;
        private ParticleSystem curretnParticleSystem;
        public void SetController(VFXController controllerToSet) => controller = controllerToSet;

        public void ConfigureAndPlay(VFXType type, Vector2 positionToSet)
        {
            gameObject.SetActive(true);
            gameObject.transform.position = positionToSet;
            foreach (var item in particleData)
            {
                if (item.type == type)
                {
                    item.particleSystem.gameObject.SetActive(true);
                    curretnParticleSystem = item.particleSystem;
                }
                else
                {
                    item.particleSystem.gameObject.SetActive(false);
                }
            }

        }

        private void Update()
        {
            if (curretnParticleSystem != null && curretnParticleSystem.isStopped)
            {
                curretnParticleSystem.gameObject.SetActive(false);
                curretnParticleSystem = null;
                controller.OnParticleEffectCompleted();
                gameObject.SetActive(false);
            }
        }

    }
}