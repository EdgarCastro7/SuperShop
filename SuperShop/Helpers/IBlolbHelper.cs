using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace SuperShop.Helpers
{
    public interface IBlolbHelper
    {
        Task<Guid> uploadBlobAsync(IFormFile file, string containerName); //recebe atraves de ficheiros

        Task<Guid> uploadBlobAsync(byte[] file, string containerName); //recebe imagens através do telemovel

        Task<Guid> uploadBlobAsync(string image, string containerName);

    }
}
