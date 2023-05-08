using System.Text.Json;

namespace StudentMS.IO
{
    public class JsonWriter
    {
        public static async Task WriteJSON<T>(List<T> students, string jsonPath)
        {
            await using (FileStream fileStream = File.Create(jsonPath))
            {
                await JsonSerializer.SerializeAsync(fileStream, students);
            }
        }
    }
}