using UnityEngine;

namespace Effect
{
    public abstract class MonoEffectHandler<T> : MonoBehaviour, IEffectHandler<T>
    {
        public abstract void OnApply(T effect);

        public abstract void OnDiscard(T effect);
    }
}