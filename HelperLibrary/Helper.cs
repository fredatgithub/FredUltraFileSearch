using System;
using System.Collections.Generic;
using System.IO;

namespace HelperLibrary
{
  public static class Helper
  {
    /// <summary>
    /// Obtient la liste des fichiers dans un répertoire spécifié.
    /// </summary>
    /// <param name="directoryPath">Chemin du répertoire.</param>
    /// <param name="searchPattern">Motif de recherche (par défaut : "*.*").</param>
    /// <param name="searchOption">Option de recherche (par défaut : TopDirectoryOnly).</param>
    /// <returns>Liste des chemins de fichiers trouvés.</returns>
    /// <exception cref="ArgumentException">Si le chemin du répertoire est invalide ou vide.</exception>
    /// <exception cref="DirectoryNotFoundException">Si le répertoire n'existe pas.</exception>
    public static List<string> GetFiles(string directoryPath, string searchPattern = "*.*", SearchOption searchOption = SearchOption.AllDirectories)
    {
      if (string.IsNullOrWhiteSpace(directoryPath))
      {
        //throw new ArgumentException("Le chemin du répertoire ne peut pas être vide ou null.", nameof(directoryPath));
        directoryPath = @"C:\";
      }

      if (!Directory.Exists(directoryPath))
      {
        throw new DirectoryNotFoundException($"Le répertoire spécifié n'existe pas : {directoryPath}");
      }

      var files = new List<string>();

      try
      {
        // Ajouter les fichiers du répertoire actuel
        files.AddRange(Directory.GetFiles(directoryPath, searchPattern));

        // Si une recherche récursive est demandée, parcourir les sous-répertoires
        if (searchOption == SearchOption.AllDirectories)
        {
          foreach (var subDirectory in Directory.GetDirectories(directoryPath))
          {
            try
            {
              // Ajouter récursivement les fichiers des sous-répertoires
              files.AddRange(GetFiles(subDirectory, searchPattern, searchOption));
            }
            catch (UnauthorizedAccessException)
            {
              // Ignorer les répertoires auxquels l'accès est refusé
              //Console.WriteLine($"Accès refusé au répertoire : {subDirectory}");
            }
          }
        }
      }
      catch (UnauthorizedAccessException)
      {
        // Ignorer le répertoire principal si l'accès est refusé
        //Console.WriteLine($"Accès refusé au répertoire : {directoryPath}");
      }

      return files;
    }
  }
}
