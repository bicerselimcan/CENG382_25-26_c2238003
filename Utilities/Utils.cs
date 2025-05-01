using System.Text.Json;

namespace DotNetWeek5App.Utilities
{
    public sealed class Utils
    {
        private static readonly Lazy<Utils> lazy = new Lazy<Utils>(() => new Utils());

        public static Utils Instance => lazy.Value;

        private Utils() { }

        public string ExportToJson<T>(List<T> data, List<string> selectedColumns = null)
        {
            if (selectedColumns == null || !selectedColumns.Any())
            {
                // Tüm datayı döndürmek için.
                return JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            }

            // Sadece seçilen kolonları içeren dictionary listesi oluşturmak için.
            var filtered = data.Select(item =>
            {
                var dict = new Dictionary<string, object>();
                var props = typeof(T).GetProperties();

                foreach (var prop in props)
                {
                    if (selectedColumns.Contains(prop.Name))
                    {
                        dict[prop.Name] = prop.GetValue(item);
                    }
                }

                return dict;
            }).ToList();

            return JsonSerializer.Serialize(filtered, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}