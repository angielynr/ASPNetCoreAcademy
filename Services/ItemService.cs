namespace Services
{
    public class ItemService
    {
        public IEnumerable<string> GetAll(int userId)
        {
            return new List<string>(userId);
        }

    }
}