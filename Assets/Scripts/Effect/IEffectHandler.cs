namespace Effect
{
    public interface IEffectHandler<in T>
    {
        void OnApply(T effect);
        
        void OnDiscard(T effect);
    }
}