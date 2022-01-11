using App03.ValueObjects;

namespace App03.Repository
{
    public interface IRepository
    {
        Money Read();

        void Write(Money money);
    }
}
