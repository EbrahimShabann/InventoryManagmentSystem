using Microsoft.AspNetCore.Identity;
using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Utilities.HelperClass;
using Inventory.Repositories;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.Net.Mail;
using System.Net;


namespace Inventory.Utilities
{
    public class DbInitializer :IDbInitializer 
    {
        private readonly UserManager<IdentityUser> _userManager;
      //  private readonly RoleManager<IdentityRole> _roleManager;
        private  SuperAdmin _superAdmin;
        private ApplicationDbContext _context;
        private IRoleInventory _roleInventory;

        public DbInitializer(UserManager<IdentityUser> userManager, /*RoleManager<IdentityRole> roleManager*/
            IOptions<SuperAdmin> superAdmin, ApplicationDbContext context, IRoleInventory roleInventory)
        {
            _userManager = userManager;
            //_roleManager = roleManager;
            _superAdmin = superAdmin.Value;
            _context = context;
            _roleInventory = roleInventory;
        }

        public async Task CreateSuperAdmin()
        {
            ApplicationUser user =new ApplicationUser ();
            user.Email = _superAdmin.Email;
            user.UserName = "Ebrahim Shaban";
            user.EmailConfirmed = true;
            var response = await _userManager.CreateAsync(user,_superAdmin.Password);
            if (response.Succeeded) { 
            UserProfile userProfile = new UserProfile ();
                userProfile.ApplicationUserId = user.Id;
                userProfile.FirstName = "Admin";
                userProfile.LastName = "Ebrahim";
                userProfile.Email = user.Email;
              await  _context.UserProfiles.AddAsync(userProfile);
                await _context.SaveChangesAsync();
                await _roleInventory.AddRoleAsync(user.Id);

            }
        }

        public async Task SendEmail(string FromEmail, string FromName, string Message, string Subject, string ToEmail, string ToName,
            string smtpUser, string smtpPassword, string smtpHost, string smtpPort, bool smtpSSL)
        {
            var body = Message;
            var messageRequst = new MailMessage();
            messageRequst.To.Add(new MailAddress(ToEmail, ToName));
            messageRequst.From= new MailAddress(FromEmail, FromName);
            messageRequst.Subject = Subject;
            messageRequst.Body = body;
            using (var smtp = new SmtpClient()) 
            { 
                var crediential = new NetworkCredential 
                {
                    UserName = smtpUser,
                    Password = smtpPassword
                };
                smtp.Credentials = crediential;
                smtp.Host=smtpHost;
                smtp.Port = Convert.ToInt32(smtpPort);
                smtp.EnableSsl=smtpSSL;
               await smtp.SendMailAsync(messageRequst);
                
            }
        }

        public async Task<string> UploadFile(List<IFormFile> files, IWebHostEnvironment env, string Directory)
        {
            var response = string.Empty;
            var upload = Path.Combine(env.WebRootPath, Directory);
            var FileName = string.Empty;
            var FilePath = string.Empty;
            var FileExtension = string.Empty;
            foreach (var file in files)
            {
                FileExtension = Path.GetExtension(file.FileName);
                FileName= Guid.NewGuid().ToString() + FileExtension;
                FilePath= Path.Combine(upload, file.FileName);
                using(var ms = new FileStream(FilePath, FileMode.Create))
                {
                    await file.CopyToAsync(ms);
                }
                response = FileName;
            }
            return response;
        }
    }
}
