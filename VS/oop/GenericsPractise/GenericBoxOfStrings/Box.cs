namespace GenericBoxOfStrings
{
    public class Box<T>
    {
        private T input;

        public Box(T input)
        {
            this.Input = input;
        }

        public T Input { get; private set; }

        public override string ToString()
        {
            return $"{Input.GetType()}: {Input}";
        }
    }
}
