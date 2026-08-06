namespace ProtectedAccessModifier
{
    public class Shape
    {
        protected int Height { get; set; }
        protected int Weidth { get; set; }

        public virtual int GetArea()
        {
            return Weidth * Height;
        }
    }
}
