namespace Less4_enum_struct_class.Model
{
    public class Point3D
    {
        private int x;
        private int y;
        private int z;
        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public override string ToString()
        {
            return $"x{x} y{y} z{z}";
        }
    }
}
