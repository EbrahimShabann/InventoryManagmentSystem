using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Utilities
{
    public interface IDbInitializer
    {
        
        void CreateSuperAdmin();
        Task SendEmail(string FromEmail, string FromName, string Message, string ToEmail, string ToName
            , string smtpUser, string smtpPassword, string smtpHost, string smtpPort, bool smtpSSL);
        Task<string> UploadFile(List<IFormFile> files, IWebHostEnvironment env, string Directory);
    }
}
