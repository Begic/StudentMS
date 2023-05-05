using System.Text.Json;
namespace StudentMS.IO;

public class JsonReader
{
    public static async Task<List<T>> ReadJSON<T>(string filePath)
    {
        using (var fileStream = File.OpenRead(filePath))
        {
            return await JsonSerializer.DeserializeAsync<List<T>>(fileStream);
        }
    }
}