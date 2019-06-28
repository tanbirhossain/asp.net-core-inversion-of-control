using DAL;

namespace BLL
{
    public interface IValueService
    {
        string getValues();
    }
    public class ValueService : IValueService
    {
        private readonly IValueRepository _valueRepository;
        public ValueService(IValueRepository valueRepository)
        {
            _valueRepository = valueRepository;
        }
        public string getValues()
        {
            return _valueRepository.getValues() + " and Service";
        }
    }
}
