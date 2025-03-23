using DT191G_Moment4.Models;
using Microsoft.EntityFrameworkCore;

namespace DT191G_Moment4.Data;


public class PlaylistContext : DbContext
{
    public PlaylistContext(DbContextOptions<PlaylistContext> options) : base(options) { }

    public DbSet<Playlist> Playlists { get; set; }
}