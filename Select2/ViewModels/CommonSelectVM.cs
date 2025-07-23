namespace Select2.ViewModels
{
    public class CommonSelectVM
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? GroupName { get; set; }
    }

    public class PaginatedResult<T>
    {
        public List<T> Items { get; set; }
        public bool HasMore { get; set; }
    }
}
