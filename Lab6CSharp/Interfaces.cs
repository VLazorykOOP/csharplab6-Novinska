namespace Lab6CSharp
{
    public interface IState
    {
        string Name { get; set; }
        void Show();
    }

    public interface IGovernment
    {
        string GovernmentType { get; set; }
    }

    public interface ICountry : IState, IGovernment
    {
        string Leader { get; set; }
    }
}
