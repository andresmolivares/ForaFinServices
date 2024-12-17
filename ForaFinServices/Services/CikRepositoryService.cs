using ForaFinServices.Services.Interfaces;

namespace ForaFinServices.Services
{
    public class CikRepositoryService : ICikRepositoryService
    {
        /// <summary>
        /// Loads CIK id values from a CSV file.
        /// </summary>
        public async Task<string[]> GetCikIds(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
            }

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file was not found.", filePath);
            }

            using (var reader = new StreamReader(filePath))
            {
                var line = await reader.ReadLineAsync();
                if (line != null)
                {
                    return line
                        .Split(',')
                        .Select(s => s.PadLeft(10, '0'))
                        .ToArray();
                }
            }

            return [];
        }
    }
}
