using System;
using Effect;
using UnityEngine;

namespace Components
{
    [Serializable]
    public sealed class Component_Effect : IComponent_GetEffect
    {
        public IEffect Effect => _effect;

        [SerializeReference]
        private IEffect _effect = default;
    }
}
