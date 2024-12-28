string userDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}";
if (args.Length == 0)
{
    string filePath = userDir + "\\wall\\0.jpg";
    string extra = "\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\TranscodedWallpaper";
    string fullPath = userDir + extra;
    Console.WriteLine(fullPath + "  " + filePath);
    File.Delete(fullPath);
    File.Copy(filePath, fullPath);
}
else 
{
    string filePath = args[0];
    string extra = "\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\TranscodedWallpaper";
    string fullPath = userDir + extra;
    Console.WriteLine(fullPath + "  " + filePath);
    File.Delete(fullPath);
    File.Copy(filePath, fullPath);
}