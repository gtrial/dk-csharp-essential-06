namespace task03
{
    internal static class Program
    {
        private static void Main()
        {
            var notes = new Book.Notes();
            notes.Save("test");
        }
    }
}