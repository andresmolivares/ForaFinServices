namespace ForaFinServices.Services.Interfaces
{
    public interface ICikDataService
    {
        Task<string[]> GetCikIds(string filePath);
    }
}
