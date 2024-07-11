namespace GymBeastLike
{
    public interface IListenerController
    {
        void Attach(IStatusGameController _listener);
        void Detach(IStatusGameController _listener);
        void Notify(float horizontal,float vertical);
    }
}
