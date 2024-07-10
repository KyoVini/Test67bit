namespace GymBeastLike
{
    public interface IListener
    {
        void Attach(IStatusGame _listener);
        void Detach(IStatusGame _listener);
        void Notify();
    }
}
