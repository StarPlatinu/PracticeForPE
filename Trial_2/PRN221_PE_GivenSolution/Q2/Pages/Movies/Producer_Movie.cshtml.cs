using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Q2.Hubs;
using Q2.Models;

namespace Q2.Pages.Movies
{
    public class Producer_MovieModel : PageModel
    {
       private readonly PE_PRN_Fall22B1Context _context;
        private readonly IHubContext<SignalRServer> _signalRHub;

        public Producer_MovieModel(PE_PRN_Fall22B1Context context, IHubContext<SignalRServer> signalRHub)
        {
            _context = context;
            _signalRHub = signalRHub;
        }

        public List<Director> Directors { get; set; }
        public List<Movie> Movies { get; set; }
        public async Task OnGetAsync(int id,int deleteid)
        {
            if (_context.Producers != null)
            {
                Directors = _context.Directors.ToList();
            }
            if(deleteid != null) { 
            {
                var movie = _context.Movies.Include(c => c.Stars).Include(x => x.Genres).FirstOrDefault(x => x.Id == deleteid);
                    
                    foreach (var item in movie.Stars.ToList())
                    {
                        movie.Stars.Remove(item);
                    }
                    foreach (var item in movie.Genres.ToList())
                    {
                        movie.Genres.Remove(item);
                    }
                    foreach (var item in _context.Stars.Include(x=>x.Movies).ToList())
                    {
                        foreach (var i in item.Movies.ToList())
                        {
                            if(i.Id == deleteid)
                            {
                                item.Movies.Remove(i);
                            }
                        }
                    }
                };
            }
        }

    }
}
