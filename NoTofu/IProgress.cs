namespace NoTofu
{
    public interface IProgress<in T>
    {
        void Report(T value);
    }
}
