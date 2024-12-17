namespace ForaFinServices.Services.Interfaces
{
    public interface ICikRepositoryService
    {
        Task<string[]> GetCikIds(string filePath);
    }
}
