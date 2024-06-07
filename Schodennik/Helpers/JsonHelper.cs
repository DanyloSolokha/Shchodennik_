using Schodennik;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

public static class JsonHelper
{

    public static void SaveToFile<T>(T data, string filename)
    {
        try
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(data, options);
            File.WriteAllText(filename, jsonString);
        }
        catch (Exception e)
        {
            MessageBox.Show($"помилка збереження: {e.Message}");
        }
    }

    public static T LoadFromFile<T>(string filename)
    {
        try
        {
            if (File.Exists(filename))
            {
                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                };

                string jsonString = File.ReadAllText(filename);
                T result = JsonSerializer.Deserialize<T>(jsonString, options);

                if (typeof(T) == typeof(Dictionary<DateTime, List<RepTask>>))
                {
                    var data = result as Dictionary<DateTime, List<RepTask>>;
                    RestoreLinks(data);
                }

                return result;
            }
            else
            {
                MessageBox.Show("файл не знайдено");
            }
        }
        catch (Exception e)
        {
            MessageBox.Show($"Помилка завантаження: {e.Message}");
        }
        return default;
    }

    private static void RestoreLinks(Dictionary<DateTime, List<RepTask>> data)
    {
        var tasksById = new Dictionary<Guid, RepTask>();

        foreach (var kvp in data)
        {
            foreach (var task in kvp.Value)
            {
                tasksById[task.Id] = task;
            }
        }

        foreach (var task in tasksById.Values)
        {
            if (task.NextId.HasValue)
            {
                task.Next = tasksById[task.NextId.Value];
            }
            if (task.PrevId.HasValue)
            {
                task.Prev = tasksById[task.PrevId.Value];
            }
        }
    }

    public static void ClearFile(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, string.Empty);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Помилка видалення данних: {ex.Message}");
        }
    }
}
