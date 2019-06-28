namespace DAL
{

    public interface IValueRepository
    {
        string getValues();
    }
    public class ValueRepository : IValueRepository
    {
        public string getValues()
        {
            return "Value from Repository";
        }
    }
}
