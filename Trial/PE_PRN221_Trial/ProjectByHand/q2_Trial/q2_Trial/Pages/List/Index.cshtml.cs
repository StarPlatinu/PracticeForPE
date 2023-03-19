using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using q2_Trial.Models;
using System.Text.Json.Serialization;
using System.Timers;

namespace q2_Trial.Pages.List
{
    public class IndexModel : PageModel
    {
        private readonly Prn221Spr22Context _context;
        public string Room { get; set; }
        public List<Service> Services { get; set; }

        public IndexModel(Prn221Spr22Context context)
        {
            _context = context;
        }

        public void OnGet(string room)
        {
            Room = room;
            if(string.IsNullOrEmpty(Room))
            {
                var month = DateTime.Now.Month;
                Services = _context.Services.Include(x => x.EmployeeNavigation).Where(x => x.Month == month).ToList();
            }
            else
            {
                Services = _context.Services.Include(x => x.EmployeeNavigation).Where(x => x.RoomTitle.Contains(Room)).ToList();
            }
        }

        public void OnPost(IFormFile inputfile)
        {
            string filecontent = string.Empty;
            using(var reader = new StreamReader(inputfile.OpenReadStream()))
            {
                filecontent = reader.ReadToEnd();
            }
            if(!string.IsNullOrEmpty(filecontent))
            {
                var listOfServices = JsonConvert.DeserializeObject<List<Service>>(filecontent);
                if(listOfServices.Count > 0)
                {
                    foreach(var service in listOfServices)
                    {
                        service.Id = 0;
                    }
                    _context.Services.AddRange(listOfServices);
                    _context.SaveChanges();
                }
            }
            Services = _context.Services.Include(x => x.EmployeeNavigation ).ToList();
        }
        
    }
}
