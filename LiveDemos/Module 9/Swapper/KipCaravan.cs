namespace Swapper
{
    internal class KipCaravan<T>
    {
        public T Aantal { get; internal set; }

        public override string ToString()
        {
            return Aantal.ToString();
        }
    }
}