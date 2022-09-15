using Microsoft.EntityFrameworkCore;
using UploadImages.Models;

namespace UploadImages.Data;

public class ApplicationDbContext : DbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
  public DbSet<FileOnDatabaseModel>? FilesOnDatabase { get; set; }
  public DbSet<FileOnFileSystemModel>? FilesOnFileSystem { get; set; }
}