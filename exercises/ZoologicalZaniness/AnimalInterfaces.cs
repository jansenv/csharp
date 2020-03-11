namespace ZoologicalZaniness
{
    public interface IWalking
    {
        void Run();
        void Walk();
    }

    public interface ISwimming
    {
        int MaximumDepth { get; }
        void Swim();
    }

    public interface IDigging
    {
        int MaximumDepth { get; }
        void Dig();
    }

    public interface IMoving
    {
        int MaximumSpeed { get; }
        void Move();
    }

    public interface IFlying
    {
        int MaximumHeight { get; }
        void Fly();
    }

}