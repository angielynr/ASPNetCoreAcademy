namespace Services
{
    public static class ItemService
    {
        public static IEnumerable<string> GetAll(int userId)
        {
            return new List<string>(userId);
        }

    }
}