using UploadImages.Models;

namespace UploadImages.Models;

public class FileOnDatabaseModel : FileModel
{
  public byte[]? Data { get; set; }
}