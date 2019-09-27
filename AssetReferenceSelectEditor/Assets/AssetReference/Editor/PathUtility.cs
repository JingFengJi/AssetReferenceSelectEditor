using System.IO;

namespace AssetReference.Editor
{
  /// <summary>路径相关的实用函数。</summary>
  public static class PathUtility
  {
    /// <summary>获取规范的路径。</summary>
    /// <param name="path">要规范的路径。</param>
    /// <returns>规范的路径。</returns>
    public static string GetRegularPath(string path)
    {
      return path?.Replace('\\', '/');
    }
    
    public static string GetCombinePath(int startIndex, int endIndex, params string[] path)
    {
      if (path == null || path.Length < 1)
        return (string) null;
      if (startIndex < 0 || startIndex >= path.Length - 1 || endIndex < 0 || endIndex > path.Length - 1 || startIndex > endIndex)
      {
        return (string) null;
      }
      string str = path[startIndex];
      for (int index = startIndex+1; index <= endIndex; ++index)
        str = Path.Combine(str, path[index]);
      return GetRegularPath(str);
    }

    public static string GetAssetDirectoryName(string assetPath)
    {
      int index = assetPath.LastIndexOf(Path.DirectorySeparatorChar);
      return assetPath.Substring(0, index);
    }

    public static string[] GetProgressiveAssetFolderPath(string assetFolderPath)
    {
      if (assetFolderPath.Contains("/"))
      {
        string[] folderName = assetFolderPath.Split(Path.DirectorySeparatorChar);
        string[] result = new string[folderName.Length];
        for (int i = 0; i < folderName.Length; i++)
        {
          result[i] = GetCombinePath(0, i, folderName);
        }

        return result;
      }
      return null;
    }
  }
}