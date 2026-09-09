#define DEBUG
using FredUltraFileSearch.Properties;
using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace FredUltraFileSearch
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
      InitializeResultContextMenu();
      checkBoxSize.CheckedChanged += CheckBoxSize_CheckedChanged;
    }

    public readonly Dictionary<string, string> _languageDicoEn = new Dictionary<string, string>();
    public readonly Dictionary<string, string> _languageDicoFr = new Dictionary<string, string>();
    private string _currentLanguage = "english";
    private ConfigurationOptions _configurationOptions = new ConfigurationOptions();
    private readonly byte padding = 25;
    private CancellationTokenSource _searchCancellationTokenSource;
    private readonly ContextMenuStrip _resultContextMenu = new ContextMenuStrip();
    private readonly ToolStripMenuItem _openFileMenuItem = new ToolStripMenuItem("Open file");
    private readonly ToolStripMenuItem _openDirectoryMenuItem = new ToolStripMenuItem("Open directory location");
    private readonly ToolStripMenuItem _commandPromptMenuItem = new ToolStripMenuItem("Command Prompt");
    private readonly ToolStripMenuItem _openWithNotepadPlusPlusMenuItem = new ToolStripMenuItem("Open with NotePad++");
    private readonly ToolStripMenuItem _openWithVisualStudioCodeMenuItem = new ToolStripMenuItem("Open with VS Code");
    private readonly ToolStripSeparator _externalToolsSeparator = new ToolStripSeparator();
    private readonly ToolStripSeparator _fileActionsSeparator = new ToolStripSeparator();
    private readonly ToolStripMenuItem _renameMenuItem = new ToolStripMenuItem("Rename");
    private readonly ToolStripMenuItem _deleteMenuItem = new ToolStripMenuItem("Delete");
    private readonly ToolStripMenuItem _propertiesMenuItem = new ToolStripMenuItem("Properties");
    private string _notepadPlusPlusPath;
    private string _visualStudioCodePath;
    private int _sortColumn = -1;
    private bool _sortAscending = true;

    private void InitializeResultContextMenu()
    {
      _openFileMenuItem.Click += OpenFileMenuItem_Click;
      _openDirectoryMenuItem.Click += OpenDirectoryMenuItem_Click;
      _commandPromptMenuItem.Click += CommandPromptMenuItem_Click;
      _openWithNotepadPlusPlusMenuItem.Click += OpenWithNotepadPlusPlusMenuItem_Click;
      _openWithVisualStudioCodeMenuItem.Click += OpenWithVisualStudioCodeMenuItem_Click;
      _renameMenuItem.Click += RenameMenuItem_Click;
      _deleteMenuItem.Click += DeleteMenuItem_Click;
      _propertiesMenuItem.Click += PropertiesMenuItem_Click;
      RefreshExternalApplicationPaths();
      _resultContextMenu.Items.AddRange(new ToolStripItem[]
      {
        _openFileMenuItem,
        _openDirectoryMenuItem,
        _externalToolsSeparator,
        _commandPromptMenuItem,
        _openWithNotepadPlusPlusMenuItem,
        _openWithVisualStudioCodeMenuItem,
        _fileActionsSeparator,
        _renameMenuItem,
        _deleteMenuItem,
        _propertiesMenuItem
      });
      _resultContextMenu.Opening += ResultContextMenu_Opening;
      listViewResult.ContextMenuStrip = _resultContextMenu;
      listViewResult.MouseUp += ListViewResult_MouseUp;
      listViewResult.ColumnClick += ListViewResult_ColumnClick;
      listViewResult.MouseDoubleClick += ListViewResult_MouseDoubleClick;
      listViewResult.SelectedIndexChanged += ListViewResult_SelectedIndexChanged;
      UpdateStatusStrip();
    }

    private void ListViewResult_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdateStatusStrip();
    }

    private void UpdateStatusStrip()
    {
      long selectedSize = listViewResult.SelectedItems.Cast<ListViewItem>()
        .Select(item => item.Tag as string)
        .Where(path => !string.IsNullOrEmpty(path) && File.Exists(path))
        .Select(path => new FileInfo(path).Length)
        .Sum();
      long totalSize = listViewResult.Items.Cast<ListViewItem>()
        .Select(item => item.Tag as string)
        .Where(path => !string.IsNullOrEmpty(path) && File.Exists(path))
        .Select(path => new FileInfo(path).Length)
        .Sum();

      toolStripStatusLabelSelection.Text =
        $"Selected {listViewResult.SelectedItems.Count} of {listViewResult.Items.Count} Objects (Size: {FormatSize(selectedSize)})";
      toolStripStatusLabelObjectsFound.Text =
        $"Objects Found: {listViewResult.Items.Count} Files";
      toolStripStatusLabelTotalSize.Text = $"Total Size: {FormatSize(totalSize)}";
    }

    private static string FormatSize(long size)
    {
      const double kilobyte = 1024d;
      const double megabyte = kilobyte * 1024d;
      const double gigabyte = megabyte * 1024d;

      if (size >= gigabyte)
      {
        return (size / gigabyte).ToString("0.00", CultureInfo.CurrentCulture) + " GB";
      }

      if (size >= megabyte)
      {
        return (size / megabyte).ToString("0.00", CultureInfo.CurrentCulture) + " MB";
      }

      if (size >= kilobyte)
      {
        return (size / kilobyte).ToString("0.00", CultureInfo.CurrentCulture) + " KB";
      }

      return size.ToString("N0", CultureInfo.CurrentCulture) + " Bytes";
    }

    private void ListViewResult_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      var item = listViewResult.HitTest(e.Location).Item;
      string filePath = item?.Tag as string;
      if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
      {
        OpenPath(filePath);
      }
    }

    private void ListViewResult_ColumnClick(object sender, ColumnClickEventArgs e)
    {
      if (_sortColumn == e.Column)
      {
        _sortAscending = !_sortAscending;
      }
      else
      {
        _sortColumn = e.Column;
        _sortAscending = true;
      }

      listViewResult.ListViewItemSorter = new ListViewItemComparer(e.Column, _sortAscending);
      listViewResult.Sort();
    }

    private void ListViewResult_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Right)
      {
        return;
      }

      var item = listViewResult.HitTest(e.Location).Item;
      if (item != null)
      {
        item.Selected = true;
        item.Focused = true;
      }
    }

    private void ResultContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {
      RefreshExternalApplicationPaths();
      string filePath = GetSelectedResultPath();
      _openFileMenuItem.Enabled = !string.IsNullOrEmpty(filePath) && File.Exists(filePath);
      _openDirectoryMenuItem.Enabled = !string.IsNullOrEmpty(filePath) &&
        Directory.Exists(Path.GetDirectoryName(filePath));
      _commandPromptMenuItem.Enabled = !string.IsNullOrEmpty(filePath);
      _openWithNotepadPlusPlusMenuItem.Visible = !string.IsNullOrEmpty(_notepadPlusPlusPath);
      _openWithNotepadPlusPlusMenuItem.Enabled = _openFileMenuItem.Enabled;
      _openWithVisualStudioCodeMenuItem.Visible = !string.IsNullOrEmpty(_visualStudioCodePath);
      _openWithVisualStudioCodeMenuItem.Enabled = _openFileMenuItem.Enabled;
      bool pathExists = !string.IsNullOrEmpty(filePath) && (File.Exists(filePath) || Directory.Exists(filePath));
      _renameMenuItem.Enabled = pathExists;
      _deleteMenuItem.Enabled = pathExists;
      _propertiesMenuItem.Enabled = pathExists;
    }

    private void RefreshExternalApplicationPaths()
    {
      _notepadPlusPlusPath = FindExecutable("notepad++.exe",
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Notepad++", "notepad++.exe"),
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Notepad++", "notepad++.exe"),
        Path.Combine(Environment.GetEnvironmentVariable("ProgramW6432") ?? string.Empty, "Notepad++", "notepad++.exe"),
        Path.Combine(Environment.GetEnvironmentVariable("ProgramFiles") ?? string.Empty, "Notepad++", "notepad++.exe"),
        Path.Combine(Environment.GetEnvironmentVariable("ProgramFiles(x86)") ?? string.Empty, "Notepad++", "notepad++.exe"));
      _visualStudioCodePath = FindExecutable("code.exe",
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs", "Microsoft VS Code", "Code.exe"),
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Microsoft VS Code", "Code.exe"),
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Microsoft VS Code", "Code.exe"),
        Path.Combine(Environment.GetEnvironmentVariable("ProgramW6432") ?? string.Empty, "Microsoft VS Code", "Code.exe"),
        Path.Combine(Environment.GetEnvironmentVariable("ProgramFiles") ?? string.Empty, "Microsoft VS Code", "Code.exe"),
        Path.Combine(Environment.GetEnvironmentVariable("ProgramFiles(x86)") ?? string.Empty, "Microsoft VS Code", "Code.exe"));
    }

    private string GetSelectedResultPath()
    {
      return listViewResult.SelectedItems.Count == 0
        ? null
        : listViewResult.SelectedItems[0].Tag as string;
    }

    private void OpenFileMenuItem_Click(object sender, EventArgs e)
    {
      OpenPath(GetSelectedResultPath());
    }

    private void OpenDirectoryMenuItem_Click(object sender, EventArgs e)
    {
      string filePath = GetSelectedResultPath();
      string directoryPath = string.IsNullOrEmpty(filePath) ? null : Path.GetDirectoryName(filePath);
      OpenPath(directoryPath);
    }

    private void CommandPromptMenuItem_Click(object sender, EventArgs e)
    {
      string path = GetSelectedResultPath();
      string directoryPath = Directory.Exists(path) ? path : Path.GetDirectoryName(path);
      if (string.IsNullOrEmpty(directoryPath))
      {
        return;
      }

      StartApplication(Environment.GetEnvironmentVariable("ComSpec") ?? "cmd.exe",
        "/K cd /d \"" + directoryPath + "\"");
    }

    private void OpenWithNotepadPlusPlusMenuItem_Click(object sender, EventArgs e)
    {
      StartApplication(_notepadPlusPlusPath, QuoteArgument(GetSelectedResultPath()));
    }

    private void OpenWithVisualStudioCodeMenuItem_Click(object sender, EventArgs e)
    {
      StartApplication(_visualStudioCodePath, QuoteArgument(GetSelectedResultPath()));
    }

    private void RenameMenuItem_Click(object sender, EventArgs e)
    {
      string path = GetSelectedResultPath();
      if (string.IsNullOrEmpty(path) || (!File.Exists(path) && !Directory.Exists(path)))
      {
        return;
      }

      string currentName = Path.GetFileName(path.TrimEnd(Path.DirectorySeparatorChar));
      string newName = Interaction.InputBox("Enter the new name:", "Rename", currentName).Trim();
      if (string.IsNullOrEmpty(newName) || string.Equals(newName, currentName, StringComparison.Ordinal))
      {
        return;
      }

      string parentDirectory = Path.GetDirectoryName(path.TrimEnd(Path.DirectorySeparatorChar));
      string newPath = Path.Combine(parentDirectory, newName);
      try
      {
        if (File.Exists(path))
        {
          File.Move(path, newPath);
        }
        else
        {
          Directory.Move(path, newPath);
        }

        listViewResult.SelectedItems[0].Tag = newPath;
        listViewResult.SelectedItems[0].SubItems[1].Text = Path.GetFileName(newPath);
        listViewResult.SelectedItems[0].SubItems[2].Text = parentDirectory;
      }
      catch (Exception exception) when (exception is IOException || exception is UnauthorizedAccessException || exception is ArgumentException)
      {
        MessageBox.Show(this, exception.Message, "Unable to rename", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void DeleteMenuItem_Click(object sender, EventArgs e)
    {
      string path = GetSelectedResultPath();
      if (string.IsNullOrEmpty(path) || (!File.Exists(path) && !Directory.Exists(path)))
      {
        return;
      }

      if (MessageBox.Show(this, "Delete the selected item?", "Confirm delete",
          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
      {
        return;
      }

      try
      {
        if (File.Exists(path))
        {
          File.Delete(path);
        }
        else
        {
          Directory.Delete(path, true);
        }

        listViewResult.Items.Remove(listViewResult.SelectedItems[0]);
        UpdateStatusStrip();
      }
      catch (Exception exception) when (exception is IOException || exception is UnauthorizedAccessException)
      {
        MessageBox.Show(this, exception.Message, "Unable to delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void PropertiesMenuItem_Click(object sender, EventArgs e)
    {
      string path = GetSelectedResultPath();
      if (string.IsNullOrEmpty(path) || (!File.Exists(path) && !Directory.Exists(path)))
      {
        return;
      }

      var shellExecuteInfo = new ShellExecuteInfo
      {
        Size = (uint)Marshal.SizeOf(typeof(ShellExecuteInfo)),
        Mask = 0x0000000C,
        Verb = "properties",
        File = path,
        Show = 1
      };

      if (!ShellExecuteEx(ref shellExecuteInfo))
      {
        MessageBox.Show(this, new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error()).Message,
          "Unable to open properties", MessageBoxButtons.OK,
          MessageBoxIcon.Error);
      }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    private struct ShellExecuteInfo
    {
      public uint Size;
      public uint Mask;
      public IntPtr WindowHandle;
      [MarshalAs(UnmanagedType.LPWStr)] public string Verb;
      [MarshalAs(UnmanagedType.LPWStr)] public string File;
      [MarshalAs(UnmanagedType.LPWStr)] public string Parameters;
      [MarshalAs(UnmanagedType.LPWStr)] public string Directory;
      public int Show;
      public IntPtr Instance;
      public IntPtr IdList;
      [MarshalAs(UnmanagedType.LPWStr)] public string Class;
      public IntPtr ClassKey;
      public uint HotKey;
      public IntPtr Icon;
      public IntPtr Process;
    }

    [DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    private static extern bool ShellExecuteEx(ref ShellExecuteInfo executeInfo);

    private static string FindExecutable(string executableName, params string[] candidatePaths)
    {
      foreach (string candidatePath in candidatePaths)
      {
        if (!string.IsNullOrEmpty(candidatePath) && File.Exists(candidatePath))
        {
          return candidatePath;
        }
      }

      string pathVariable = Environment.GetEnvironmentVariable("PATH") ?? string.Empty;
      foreach (string directory in pathVariable.Split(Path.PathSeparator))
      {
        string path = Path.Combine(directory.Trim(), executableName);
        if (File.Exists(path))
        {
          return path;
        }
      }

      return null;
    }

    private static string QuoteArgument(string value)
    {
      return "\"" + (value ?? string.Empty).Replace("\"", "\\\"") + "\"";
    }

    private static void StartApplication(string executablePath, string arguments)
    {
      if (string.IsNullOrEmpty(executablePath))
      {
        return;
      }

      try
      {
        Process.Start(new ProcessStartInfo
        {
          FileName = executablePath,
          Arguments = arguments,
          UseShellExecute = true
        });
      }
      catch (Exception exception) when (exception is IOException || exception is System.ComponentModel.Win32Exception)
      {
        MessageBox.Show(exception.Message, "Unable to open application", MessageBoxButtons.OK,
          MessageBoxIcon.Error);
      }
    }

    private static void OpenPath(string path)
    {
      if (string.IsNullOrEmpty(path))
      {
        return;
      }

      try
      {
        Process.Start(new ProcessStartInfo
        {
          FileName = path,
          UseShellExecute = true
        });
      }
      catch (Exception exception) when (exception is IOException || exception is System.ComponentModel.Win32Exception)
      {
        MessageBox.Show(exception.Message, "Unable to open path", MessageBoxButtons.OK,
          MessageBoxIcon.Error);
      }
    }

    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveWindowValue();
      Application.Exit();
    }

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutBoxApplication aboutBoxApplication = new AboutBoxApplication();
      aboutBoxApplication.ShowDialog();
    }

    private void DisplayTitle()
    {
      Text += GetAssemblyInformation();
    }

    private static string GetAssemblyInformation()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      return string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      LoadSettingsAtStartup();
    }

    private void LoadSettingsAtStartup()
    {
      DisplayTitle();
      GetWindowValue();
      LoadLanguages();
      SetLanguage(Settings.Default.LastLanguageUsed);
    }

    private void LoadConfigurationOptions()
    {
      _configurationOptions.Option1Name = Settings.Default.Option1Name;
      _configurationOptions.Option2Name = Settings.Default.Option2Name;
    }

    private void SaveConfigurationOptions()
    {
      _configurationOptions.Option1Name = Settings.Default.Option1Name;
      _configurationOptions.Option2Name = Settings.Default.Option2Name;
    }

    private void LoadLanguages()
    {
      if (!File.Exists(Settings.Default.LanguageFileName))
      {
        CreateLanguageFile();
      }

      // read the translation file and feed the language
      XDocument xDoc;
      try
      {
        xDoc = XDocument.Load(Settings.Default.LanguageFileName);
      }
      catch (Exception exception)
      {
        MessageBox.Show(Resources.Error_while_loading_the + Punctuation.OneSpace +
          Settings.Default.LanguageFileName + Punctuation.OneSpace + Resources.XML_file +
          Punctuation.OneSpace + exception.Message);
        CreateLanguageFile();
        return;
      }

      var result = from node in xDoc.Descendants("term")
                   where node.HasElements
                   let xElementName = node.Element("name")
                   where xElementName != null
                   let xElementEnglish = node.Element("englishValue")
                   where xElementEnglish != null
                   let xElementFrench = node.Element("frenchValue")
                   where xElementFrench != null
                   select new
                   {
                     name = xElementName.Value,
                     englishValue = xElementEnglish.Value,
                     frenchValue = xElementFrench.Value
                   };

      foreach (var i in result)
      {
        if (!_languageDicoEn.ContainsKey(i.name))
        {
          _languageDicoEn.Add(i.name, i.englishValue);
        }
#if DEBUG
        else
        {
          MessageBox.Show(Resources.Your_XML_file_has_duplicate_like + Punctuation.Colon +
            Punctuation.OneSpace + i.name);
        }
#endif
        if (!_languageDicoFr.ContainsKey(i.name))
        {
          _languageDicoFr.Add(i.name, i.frenchValue);
        }
#if DEBUG
        else
        {
          MessageBox.Show(Resources.Your_XML_file_has_duplicate_like + Punctuation.Colon +
            Punctuation.OneSpace + i.name);
        }
#endif
      }
    }

    private static void CreateLanguageFile()
    {
      List<string> minimumVersion = new List<string>
      {
        "<?xml version=\"1.0\" encoding=\"utf-8\" ?>",
        "<terms>",
         "<term>",
        "<name>MenuFile</name>",
        "<englishValue>File</englishValue>",
        "<frenchValue>Fichier</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFileNew</name>",
        "<englishValue>New</englishValue>",
        "<frenchValue>Nouveau</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFileOpen</name>",
        "<englishValue>Open</englishValue>",
        "<frenchValue>Ouvrir</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFileSave</name>",
        "<englishValue>Save</englishValue>",
        "<frenchValue>Enregistrer</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFileSaveAs</name>",
        "<englishValue>Save as ...</englishValue>",
        "<frenchValue>Enregistrer sous ...</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFilePrint</name>",
        "<englishValue>Print ...</englishValue>",
        "<frenchValue>Imprimer ...</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenufilePageSetup</name>",
          "<englishValue>Page setup</englishValue>",
          "<frenchValue>Aperçu avant impression</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenufileQuit</name>",
          "<englishValue>Quit</englishValue>",
          "<frenchValue>Quitter</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEdit</name>",
          "<englishValue>Edit</englishValue>",
          "<frenchValue>Edition</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditCancel</name>",
          "<englishValue>Cancel</englishValue>",
          "<frenchValue>Annuler</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditRedo</name>",
          "<englishValue>Redo</englishValue>",
          "<frenchValue>Rétablir</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditCut</name>",
          "<englishValue>Cut</englishValue>",
          "<frenchValue>Couper</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditCopy</name>",
          "<englishValue>Copy</englishValue>",
          "<frenchValue>Copier</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditPaste</name>",
          "<englishValue>Paste</englishValue>",
          "<frenchValue>Coller</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditSelectAll</name>",
          "<englishValue>Select All</englishValue>",
          "<frenchValue>Sélectionner tout</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuTools</name>",
          "<englishValue>Tools</englishValue>",
          "<frenchValue>Outils</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuToolsCustomize</name>",
          "<englishValue>Customize ...</englishValue>",
          "<frenchValue>Personaliser ...</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuToolsOptions</name>",
          "<englishValue>Options</englishValue>",
          "<frenchValue>Options</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuLanguage</name>",
          "<englishValue>Language</englishValue>",
          "<frenchValue>Langage</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuLanguageEnglish</name>",
          "<englishValue>English</englishValue>",
          "<frenchValue>Anglais</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuLanguageFrench</name>",
          "<englishValue>French</englishValue>",
          "<frenchValue>Français</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelp</name>",
          "<englishValue>Help</englishValue>",
          "<frenchValue>Aide</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelpSummary</name>",
          "<englishValue>Summary</englishValue>",
          "<frenchValue>Sommaire</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelpIndex</name>",
          "<englishValue>Index</englishValue>",
          "<frenchValue>Index</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelpSearch</name>",
          "<englishValue>Search</englishValue>",
          "<frenchValue>Rechercher</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelpAbout</name>",
          "<englishValue>About</englishValue>",
          "<frenchValue>A propos de ...</frenchValue>",
        "</term>",
        "</terms>"
      };
      StreamWriter sw = new StreamWriter(Settings.Default.LanguageFileName);
      foreach (string item in minimumVersion)
      {
        sw.WriteLine(item);
      }

      sw.Close();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
      if (Settings.Default.WindowMaximized)
      {
        WindowState = FormWindowState.Maximized;
      }
      comboBoxStartingFolder.Text = Settings.Default.ComboBoxStartingFolderValue;
      comboBoxFileName.Text = Settings.Default.ComboBoxFileNameValue;
      comboBoxSearchText.Text = Settings.Default.ComboBoxSearchTextValue;
      comboBoxContainingTextMode.Text = Settings.Default.ComboBoxContainingTextModeValue;
      checkBoxCaseSensitive.Checked = Settings.Default.ContainingTextCaseSensitive;
      checkBoxwholeWords.Checked = Settings.Default.ContainingTextWholeWords;
      checkBoxWithout.Checked = Settings.Default.ContainingTextWithout;
      radioButtonContainingTextMatchAll.Checked = Settings.Default.ContainingTextMatchAll;
      radioButtonContainingTextMatchAny.Checked = !radioButtonContainingTextMatchAll.Checked;
      checkBoxSkipHiddenFiles.Checked = Settings.Default.SkipHiddenFiles;
      checkBoxSkipSystemFiles.Checked = Settings.Default.SkipSystemFiles;
      checkBoxSkipImageFiles.Checked = Settings.Default.SkipImageFiles;
      checkBoxSkipAudioFiles.Checked = Settings.Default.SkipAudioFiles;
      checkBoxSkipVideoFiles.Checked = Settings.Default.SkipVideoFiles;
      SetDisplayOption(Settings.Default.DisplayToolStripMenuItem);
      LoadConfigurationOptions();
    }

    private void SaveWindowValue()
    {
      var bounds = WindowState == FormWindowState.Normal ? Bounds : RestoreBounds;
      Settings.Default.WindowHeight = bounds.Height;
      Settings.Default.WindowWidth = bounds.Width;
      Settings.Default.WindowLeft = bounds.Left;
      Settings.Default.WindowTop = bounds.Top;
      Settings.Default.WindowMaximized = WindowState == FormWindowState.Maximized;
      Settings.Default.LastLanguageUsed = frenchToolStripMenuItem.Checked ? "French" : "English";
      Settings.Default.DisplayToolStripMenuItem = GetDisplayOption();
      Settings.Default.ComboBoxStartingFolderValue = comboBoxStartingFolder.Text;
      Settings.Default.ComboBoxFileNameValue = comboBoxFileName.Text;
      Settings.Default.ComboBoxSearchTextValue = comboBoxSearchText.Text;
      Settings.Default.ComboBoxContainingTextModeValue = comboBoxContainingTextMode.Text;
      Settings.Default.ContainingTextCaseSensitive = checkBoxCaseSensitive.Checked;
      Settings.Default.ContainingTextWholeWords = checkBoxwholeWords.Checked;
      Settings.Default.ContainingTextWithout = checkBoxWithout.Checked;
      Settings.Default.ContainingTextMatchAll = radioButtonContainingTextMatchAll.Checked;
      Settings.Default.SkipHiddenFiles = checkBoxSkipHiddenFiles.Checked;
      Settings.Default.SkipSystemFiles = checkBoxSkipSystemFiles.Checked;
      Settings.Default.SkipImageFiles = checkBoxSkipImageFiles.Checked;
      Settings.Default.SkipAudioFiles = checkBoxSkipAudioFiles.Checked;
      Settings.Default.SkipVideoFiles = checkBoxSkipVideoFiles.Checked;
      SaveConfigurationOptions();
      Settings.Default.Save();
    }

    private string GetDisplayOption()
    {
      if (SmallToolStripMenuItem.Checked)
      {
        return "Small";
      }

      if (MediumToolStripMenuItem.Checked)
      {
        return "Medium";
      }

      return LargeToolStripMenuItem.Checked ? "Large" : string.Empty;
    }

    private void SetDisplayOption(string option)
    {
      UncheckAllOptions();
      switch (option.ToLower())
      {
        case "small":
          SmallToolStripMenuItem.Checked = true;
          break;
        case "medium":
          MediumToolStripMenuItem.Checked = true;
          break;
        case "large":
          LargeToolStripMenuItem.Checked = true;
          break;
        default:
          SmallToolStripMenuItem.Checked = true;
          break;
      }
    }

    private void UncheckAllOptions()
    {
      SmallToolStripMenuItem.Checked = false;
      MediumToolStripMenuItem.Checked = false;
      LargeToolStripMenuItem.Checked = false;
    }

    private void FormMainFormClosing(object sender, FormClosingEventArgs e)
    {
      SaveWindowValue();
    }

    private void FrenchToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _currentLanguage = Language.French.ToString();
      SetLanguage(Language.French.ToString());
      AdjustAllControls();
    }

    private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _currentLanguage = Language.English.ToString();
      SetLanguage(Language.English.ToString());
      AdjustAllControls();
    }

    private void SetLanguage(string myLanguage)
    {
      switch (myLanguage)
      {
        case "English":
          frenchToolStripMenuItem.Checked = false;
          englishToolStripMenuItem.Checked = true;
          fileToolStripMenuItem.Text = _languageDicoEn["MenuFile"];
          newToolStripMenuItem.Text = _languageDicoEn["MenuFileNew"];
          openToolStripMenuItem.Text = _languageDicoEn["MenuFileOpen"];
          saveToolStripMenuItem.Text = _languageDicoEn["MenuFileSave"];
          saveasToolStripMenuItem.Text = _languageDicoEn["MenuFileSaveAs"];
          printPreviewToolStripMenuItem.Text = _languageDicoEn["MenuFilePrint"];
          printPreviewToolStripMenuItem.Text = _languageDicoEn["MenufilePageSetup"];
          quitToolStripMenuItem.Text = _languageDicoEn["MenufileQuit"];
          editToolStripMenuItem.Text = _languageDicoEn["MenuEdit"];
          cancelToolStripMenuItem.Text = _languageDicoEn["MenuEditCancel"];
          redoToolStripMenuItem.Text = _languageDicoEn["MenuEditRedo"];
          cutToolStripMenuItem.Text = _languageDicoEn["MenuEditCut"];
          copyToolStripMenuItem.Text = _languageDicoEn["MenuEditCopy"];
          pasteToolStripMenuItem.Text = _languageDicoEn["MenuEditPaste"];
          selectAllToolStripMenuItem.Text = _languageDicoEn["MenuEditSelectAll"];
          toolsToolStripMenuItem.Text = _languageDicoEn["MenuTools"];
          optionsToolStripMenuItem.Text = _languageDicoEn["MenuToolsOptions"];
          languagetoolStripMenuItem.Text = _languageDicoEn["MenuLanguage"];
          englishToolStripMenuItem.Text = _languageDicoEn["MenuLanguageEnglish"];
          frenchToolStripMenuItem.Text = _languageDicoEn["MenuLanguageFrench"];
          helpToolStripMenuItem.Text = _languageDicoEn["MenuHelp"];
          aboutToolStripMenuItem.Text = _languageDicoEn["MenuHelpAbout"];
          DisplayToolStripMenuItem.Text = _languageDicoEn["Display"];
          SmallToolStripMenuItem.Text = _languageDicoEn["Small"];
          MediumToolStripMenuItem.Text = _languageDicoEn["Medium"];
          LargeToolStripMenuItem.Text = _languageDicoEn["Large"];


          _currentLanguage = "English";
          break;
        case "French":
          frenchToolStripMenuItem.Checked = true;
          englishToolStripMenuItem.Checked = false;
          fileToolStripMenuItem.Text = _languageDicoFr["MenuFile"];
          newToolStripMenuItem.Text = _languageDicoFr["MenuFileNew"];
          openToolStripMenuItem.Text = _languageDicoFr["MenuFileOpen"];
          saveToolStripMenuItem.Text = _languageDicoFr["MenuFileSave"];
          saveasToolStripMenuItem.Text = _languageDicoFr["MenuFileSaveAs"];
          printPreviewToolStripMenuItem.Text = _languageDicoFr["MenuFilePrint"];
          printPreviewToolStripMenuItem.Text = _languageDicoFr["MenufilePageSetup"];
          quitToolStripMenuItem.Text = _languageDicoFr["MenufileQuit"];
          editToolStripMenuItem.Text = _languageDicoFr["MenuEdit"];
          cancelToolStripMenuItem.Text = _languageDicoFr["MenuEditCancel"];
          redoToolStripMenuItem.Text = _languageDicoFr["MenuEditRedo"];
          cutToolStripMenuItem.Text = _languageDicoFr["MenuEditCut"];
          copyToolStripMenuItem.Text = _languageDicoFr["MenuEditCopy"];
          pasteToolStripMenuItem.Text = _languageDicoFr["MenuEditPaste"];
          selectAllToolStripMenuItem.Text = _languageDicoFr["MenuEditSelectAll"];
          toolsToolStripMenuItem.Text = _languageDicoFr["MenuTools"];
          optionsToolStripMenuItem.Text = _languageDicoFr["MenuToolsOptions"];
          languagetoolStripMenuItem.Text = _languageDicoFr["MenuLanguage"];
          englishToolStripMenuItem.Text = _languageDicoFr["MenuLanguageEnglish"];
          frenchToolStripMenuItem.Text = _languageDicoFr["MenuLanguageFrench"];
          helpToolStripMenuItem.Text = _languageDicoFr["MenuHelp"];
          aboutToolStripMenuItem.Text = _languageDicoFr["MenuHelpAbout"];
          DisplayToolStripMenuItem.Text = _languageDicoFr["Display"];
          SmallToolStripMenuItem.Text = _languageDicoFr["Small"];
          MediumToolStripMenuItem.Text = _languageDicoFr["Medium"];
          LargeToolStripMenuItem.Text = _languageDicoFr["Large"];

          _currentLanguage = "French";
          break;
        default:
          SetLanguage("English");
          break;
      }
    }

    private void CutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { }); // add your controls in the List
      if (focusedControl is TextBox tb)
      {
        CutToClipboard(tb);
      }
    }

    private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { }); // add your controls in the List
      if (focusedControl is TextBox tb)
      {
        CopyToClipboard(tb);
      }
    }

    private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { }); // add your controls in the List
      if (focusedControl is TextBox tb)
      {
        PasteFromClipboard(tb);
      }
    }

    private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { }); // add your controls in the List
      if (focusedControl is TextBox control)
      {
        control.SelectAll();
      }
    }

    private void CutToClipboard(TextBoxBase tb, string errorMessage = "nothing")
    {
      if (tb != ActiveControl) return;
      if (tb.Text == string.Empty)
      {
        DisplayMessage(Translate("ThereIs") + Punctuation.OneSpace +
          Translate(errorMessage) + Punctuation.OneSpace +
          Translate("ToCut") + Punctuation.OneSpace, Translate(errorMessage),
          MessageBoxButtons.OK);
        return;
      }

      if (tb.SelectedText == string.Empty)
      {
        DisplayMessage(Translate("NoTextHasBeenSelected"),
          Translate(errorMessage), MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(tb.SelectedText);
      tb.SelectedText = string.Empty;
    }

    private void CopyToClipboard(TextBoxBase tb, string message = "nothing")
    {
      if (tb != ActiveControl) return;
      if (tb.Text == string.Empty)
      {
        DisplayMessage(Translate("ThereIsNothingToCopy") + Punctuation.OneSpace,
          Translate(message), MessageBoxButtons.OK);
        return;
      }

      if (tb.SelectedText == string.Empty)
      {
        DisplayMessage(Translate("NoTextHasBeenSelected"),
          Translate(message), MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(tb.SelectedText);
    }

    private void PasteFromClipboard(TextBoxBase tb)
    {
      if (tb != ActiveControl) return;
      var selectionIndex = tb.SelectionStart;
      tb.SelectedText = Clipboard.GetText();
      tb.SelectionStart = selectionIndex + Clipboard.GetText().Length;
    }

    private void DisplayMessage(string message, string title, MessageBoxButtons buttons)
    {
      MessageBox.Show(this, message, title, buttons);
    }

    private string Translate(string index)
    {
      string result = string.Empty;
      switch (_currentLanguage.ToLower())
      {
        case "english":
          result = _languageDicoEn.ContainsKey(index) ? _languageDicoEn[index] :
           "the term: \"" + index + "\" has not been translated yet.\nPlease tell the developer to translate this term";
          break;
        case "french":
          result = _languageDicoFr.ContainsKey(index) ? _languageDicoFr[index] :
            "the term: \"" + index + "\" has not been translated yet.\nPlease tell the developer to translate this term";
          break;
      }

      return result;
    }

    private static Control FindFocusedControl(Control container)
    {
      foreach (Control childControl in container.Controls.Cast<Control>().Where(childControl => childControl.Focused))
      {
        return childControl;
      }

      return (from Control childControl in container.Controls
              select FindFocusedControl(childControl)).FirstOrDefault(maybeFocusedControl => maybeFocusedControl != null);
    }

    private static Control FindFocusedControl(List<Control> container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }

    private static Control FindFocusedControl(params Control[] container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }

    private static Control FindFocusedControl(IEnumerable<Control> container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }

    private static string PeekDirectory()
    {
      string result = string.Empty;
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      if (fbd.ShowDialog() == DialogResult.OK)
      {
        result = fbd.SelectedPath;
      }

      return result;
    }

    private string PeekFile()
    {
      string result = string.Empty;
      OpenFileDialog fd = new OpenFileDialog();
      if (fd.ShowDialog() == DialogResult.OK)
      {
        result = fd.SafeFileName;
      }

      return result;
    }

    private void SmallToolStripMenuItem_Click(object sender, EventArgs e)
    {
      UncheckAllOptions();
      SmallToolStripMenuItem.Checked = true;
      AdjustAllControls();
    }

    private void MediumToolStripMenuItem_Click(object sender, EventArgs e)
    {
      UncheckAllOptions();
      MediumToolStripMenuItem.Checked = true;
      AdjustAllControls();
    }

    private void LargeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      UncheckAllOptions();
      LargeToolStripMenuItem.Checked = true;
      AdjustAllControls();
    }

    private static void AdjustControls(params Control[] listOfControls)
    {
      if (listOfControls.Length == 0)
      {
        return;
      }

      int position = listOfControls[0].Width + 33; // 33 is the initial padding
      bool isFirstControl = true;
      foreach (Control control in listOfControls)
      {
        if (isFirstControl)
        {
          isFirstControl = false;
        }
        else
        {
          control.Left = position + 10;
          position += control.Width;
        }
      }
    }

    private void AdjustAllControls()
    {
      AdjustControls(); // insert here all labels, textboxes and buttons, one method per line of controls
    }

    private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormOptions frmOptions = new FormOptions(_configurationOptions);

      if (frmOptions.ShowDialog() == DialogResult.OK)
      {
        _configurationOptions = frmOptions.ConfigurationOptions2;
      }
    }

    private static void SetButtonEnabled(Button button, params Control[] controls)
    {
      bool result = true;
      foreach (Control ctrl in controls)
      {
        if (ctrl.GetType() == typeof(TextBox))
        {
          if (((TextBox)ctrl).Text == string.Empty)
          {
            result = false;
            break;
          }
        }

        if (ctrl.GetType() == typeof(ListView))
        {
          if (((ListView)ctrl).Items.Count == 0)
          {
            result = false;
            break;
          }
        }

        if (ctrl.GetType() == typeof(ComboBox))
        {
          if (((ComboBox)ctrl).SelectedIndex == -1)
          {
            result = false;
            break;
          }
        }
      }

      button.Enabled = result;
    }

    private void TextBoxName_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        // do something
      }
    }

    private void FormMain_ClientSizeChanged(object sender, EventArgs e)
    {
      if (this.Width < 750)
      {
        this.Width = 750;
      }

      if (this.Height < 500)
      {
        this.Height = 500;
      }

      buttonSearch.Left = this.Width - buttonSearch.Width - padding;
      buttonReset.Left = this.Width - buttonReset.Width - padding;
      buttonStop.Left = this.Width - buttonStop.Width - padding;
    }

    private void CheckBoxDate_CheckedChanged(object sender, EventArgs e)
    {
      EnableDisableControls(GetDateFilterControls(), checkBoxDate.Checked);
    }

    private Control[] GetDateFilterControls()
    {
      return new[]
      {
        (Control)checkBoxDateModified, checkBoxDateCreation, checkBoxDateLastAccess,
        comboBoxDateModifiedBetween, dateTimePickerDateModifiedStart,
        numericUpDownDateModifiedStartHour, numericUpDownDateModifiedStartMinute,
        numericUpDownDateModifiedStartSecond, labelAndDateModified,
        dateTimePickerDateModifiedEnd, numericUpDownDateModifiedEndHour,
        numericUpDownDateModifiedEndMinute, numericUpDownDateModifiedEndSecond,
        comboBoxDateCreationBetween, dateTimePickerDateCreationStart,
        numericUpDownDateCreationStartHour, numericUpDownDateCreationStartMinute,
        numericUpDownDateCreationStartsecond, labelAndDateCreation,
        dateTimePickerDateCreationEnd, numericUpDown12, numericUpDown11, numericUpDown10,
        comboBoxDateLastAccessBetween, dateTimePickerDateLastAccessStart,
        numericUpDown6, numericUpDown5, numericUpDown4, labelAndDateLastAccess,
        dateTimePickerDateLastAccessEnd, numericUpDown15, numericUpDown14, numericUpDown13
      };
    }

    private void EnableDisableControls(Control[] listOfControls, bool toBeTrue = true)
    {
      foreach (Control ctrl in listOfControls)
      {
        ctrl.Enabled = toBeTrue;
      }
    }

    private void CheckBoxSize_CheckedChanged(object sender, EventArgs e)
    {
      EnableDisableControls(new[]
      {
        (Control)comboBoxBetweenSize, numericUpDownSizeFrom, comboBoxSizeMbKb,
        labelSizeAnd, numericUpDownSizeTo, comboBox1
      }, checkBoxSize.Checked);
    }

    private void CheckBoxAttributes_CheckedChanged(object sender, EventArgs e)
    {
      EnableDisableControls(new[]
      {
        (Control)radioButtonAttributesAny, radioButtonAttributesAll,
        radioButtonAttributesOnly, checkBoxAttributeNormal, checkBoxAttributeArchive,
        checkBoxAttributeReadOnly, checkBoxAttributeSystem, checkBoxAttributeHidden,
        checkBoxAttributeDirectory, checkBoxAttributeCompressed, checkBoxAttributeEncrypted,
        checkBoxAttributeTemporary, checkBoxAttributeNotIndexed,
        checkBoxAttributeReparsePoint, checkBoxAttributeSparseFile, checkBoxAttributeOffline
      }, checkBoxAttributes.Checked);
    }

    private async void ButtonSearch_Click(object sender, EventArgs e)
    {
      string searchPattern = comboBoxFileName.Text.Trim();
      if (searchPattern == string.Empty)
      {
        MessageBox.Show("No pattern to search", "No text", MessageBoxButtons.OK);
        return;
      }

      var startDirectory = @"C:\";
      if (!string.IsNullOrEmpty(comboBoxStartingFolder.Text))
      {
        startDirectory = comboBoxStartingFolder.Text;
      }

      buttonSearch.Enabled = false;
      buttonStop.Enabled = true;
      toolStripStatusLabelBusy.Text = "Busy";
      toolStripStatusLabelBusyIndicator.Visible = true;
      toolStripStatusLabelBusyIndicator.BackColor = Color.Red;
      _searchCancellationTokenSource = new CancellationTokenSource();
      if (!checkBoxAppendResults.Checked)
      {
        listViewResult.Items.Clear();
      }
      UpdateStatusStrip();
      bool searchCompleted = false;
      try
      {
        var progress = new Progress<string>(file =>
        {
          toolStripStatusLabelCurrentFile.Text = file;
          FileSystemInfo fileInfo = Directory.Exists(file)
            ? (FileSystemInfo)new DirectoryInfo(file)
            : new FileInfo(file);
          if (MatchesFileFilters(fileInfo))
          {
            var item = listViewResult.Items.Add(CreateResultItem(fileInfo));
            item.EnsureVisible();
            UpdateStatusStrip();
          }
        });
        var cancellationToken = _searchCancellationTokenSource.Token;
        await Task.Run(() => Helper.GetFiles(
          startDirectory, searchPattern, SearchOption.AllDirectories, progress, cancellationToken,
          checkBoxAttributeDirectory.Checked),
          cancellationToken);
        searchCompleted = true;
      }
      catch (OperationCanceledException)
      {
        toolStripStatusLabelCurrentFile.Text = "Search cancelled";
      }
      catch (Exception exception) when (exception is ArgumentException ||
                                        exception is DirectoryNotFoundException ||
                                        exception is IOException)
      {
        MessageBox.Show(this, exception.Message, "Search error", MessageBoxButtons.OK,
          MessageBoxIcon.Error);
      }
      finally
      {
        buttonSearch.Enabled = true;
        buttonStop.Enabled = false;
        toolStripStatusLabelBusy.Text = "Ready";
        toolStripStatusLabelBusyIndicator.BackColor = Color.Green;
        toolStripStatusLabelBusyIndicator.Visible = true;
        _searchCancellationTokenSource.Dispose();
        _searchCancellationTokenSource = null;
      }

      if (searchCompleted)
      {
        ResizeResultColumnsToContent();
        int fileCount = listViewResult.Items.Count;
        string fileLabel = fileCount == 1 ? "fichier" : "fichiers";
        toolStripStatusLabelCurrentFile.Text =
          $"{fileCount} {fileLabel} {searchPattern} trouvés";
      }
    }

    private void ResizeResultColumnsToContent()
    {
      if (listViewResult.Items.Count == 0)
      {
        return;
      }

      foreach (ColumnHeader column in listViewResult.Columns)
      {
        column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
      }

      EnsureMinimumColumnWidth(columnHeaderExtension);
      EnsureMinimumColumnWidth(columnHeaderType);
      EnsureMinimumColumnWidth(columnHeaderAttributes);
    }

    private static void EnsureMinimumColumnWidth(ColumnHeader column)
    {
      int minimumWidth = TextRenderer.MeasureText(column.Text, SystemFonts.DefaultFont).Width + 16;
      if (column.Width < minimumWidth)
      {
        column.Width = minimumWidth;
      }
    }

    private ListViewItem CreateResultItem(FileSystemInfo fileInfo)
    {
      var item = new ListViewItem((listViewResult.Items.Count + 1).ToString());
      item.Tag = fileInfo.FullName;
      item.SubItems.Add(fileInfo.Name);
      var file = fileInfo as FileInfo;
      var directory = fileInfo as DirectoryInfo;
      item.SubItems.Add(file != null ? file.DirectoryName : directory.Parent?.FullName);
      item.SubItems.Add(file == null ? "0" : file.Length.ToString("#,0", CultureInfo.InvariantCulture).Replace(',', ' '));
      item.SubItems.Add(file == null ? string.Empty : file.Extension);
      item.SubItems.Add(file == null ? "Directory" : "File");
      item.SubItems.Add(fileInfo.Attributes.ToString());
      item.SubItems.Add(fileInfo.LastWriteTime.ToString());
      item.SubItems.Add(fileInfo.CreationTime.ToString());
      item.SubItems.Add(fileInfo.LastAccessTime.ToString());
      return item;
    }

    private bool MatchesDateFilters(FileSystemInfo fileInfo)
    {
      if (!checkBoxDate.Checked)
      {
        return true;
      }

      return (!checkBoxDateModified.Checked || MatchesDateFilter(
          fileInfo.LastWriteTime, comboBoxDateModifiedBetween.Text,
          GetDateTime(dateTimePickerDateModifiedStart, numericUpDownDateModifiedStartHour,
            numericUpDownDateModifiedStartMinute, numericUpDownDateModifiedStartSecond),
          GetDateTime(dateTimePickerDateModifiedEnd, numericUpDownDateModifiedEndHour,
            numericUpDownDateModifiedEndMinute, numericUpDownDateModifiedEndSecond))) &&
        (!checkBoxDateCreation.Checked || MatchesDateFilter(
          fileInfo.CreationTime, comboBoxDateCreationBetween.Text,
          GetDateTime(dateTimePickerDateCreationStart, numericUpDownDateCreationStartHour,
            numericUpDownDateCreationStartMinute, numericUpDownDateCreationStartsecond),
          GetDateTime(dateTimePickerDateCreationEnd, numericUpDown12, numericUpDown11, numericUpDown10))) &&
        (!checkBoxDateLastAccess.Checked || MatchesDateFilter(
          fileInfo.LastAccessTime, comboBoxDateLastAccessBetween.Text,
          GetDateTime(dateTimePickerDateLastAccessStart, numericUpDown6, numericUpDown5, numericUpDown4),
          GetDateTime(dateTimePickerDateLastAccessEnd, numericUpDown15, numericUpDown14, numericUpDown13)));
    }

    private bool MatchesFileFilters(FileSystemInfo fileInfo)
    {
      return MatchesDateFilters(fileInfo) &&
        MatchesSizeFilter(fileInfo as FileInfo) &&
        MatchesAttributeFilters(fileInfo) &&
        MatchesContainingText(fileInfo);
    }

    private bool MatchesSizeFilter(FileInfo fileInfo)
    {
      if (!checkBoxSize.Checked || fileInfo == null)
      {
        return true;
      }

      decimal startSize = GetSizeInBytes(numericUpDownSizeFrom.Value, comboBoxSizeMbKb.Text);
      decimal endSize = GetSizeInBytes(numericUpDownSizeTo.Value, comboBox1.Text);
      decimal size = fileInfo.Length;

      switch (comboBoxBetweenSize.Text)
      {
        case "Not Between":
          return size < startSize || size > endSize;
        case "Larger than":
          return size >= startSize;
        case "Smaller than":
          return size <= startSize;
        case "Between":
        default:
          return size >= startSize && size <= endSize;
      }
    }

    private static decimal GetSizeInBytes(decimal value, string unit)
    {
      switch (unit)
      {
        case "GB":
          return value * 1024m * 1024m * 1024m;
        case "MB":
          return value * 1024m * 1024m;
        case "KB":
          return value * 1024m;
        case "Bytes":
        default:
          return value;
      }
    }

    private bool MatchesAttributeFilters(FileSystemInfo fileInfo)
    {
      if (checkBoxSkipHiddenFiles.Checked &&
          (fileInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
      {
        return false;
      }

      if (checkBoxSkipSystemFiles.Checked &&
          (fileInfo.Attributes & FileAttributes.System) == FileAttributes.System)
      {
        return false;
      }

      if (!checkBoxAttributeDirectory.Checked && fileInfo is DirectoryInfo)
      {
        return false;
      }

      FileAttributes selectedAttributes = FileAttributes.Normal;
      if (checkBoxAttributeArchive.Checked) selectedAttributes |= FileAttributes.Archive;
      if (checkBoxAttributeReadOnly.Checked) selectedAttributes |= FileAttributes.ReadOnly;
      if (checkBoxAttributeSystem.Checked) selectedAttributes |= FileAttributes.System;
      if (checkBoxAttributeHidden.Checked) selectedAttributes |= FileAttributes.Hidden;
      if (checkBoxAttributeDirectory.Checked) selectedAttributes |= FileAttributes.Directory;
      if (checkBoxAttributeCompressed.Checked) selectedAttributes |= FileAttributes.Compressed;
      if (checkBoxAttributeEncrypted.Checked) selectedAttributes |= FileAttributes.Encrypted;
      if (checkBoxAttributeTemporary.Checked) selectedAttributes |= FileAttributes.Temporary;
      if (checkBoxAttributeNotIndexed.Checked) selectedAttributes |= FileAttributes.NotContentIndexed;
      if (checkBoxAttributeReparsePoint.Checked) selectedAttributes |= FileAttributes.ReparsePoint;
      if (checkBoxAttributeSparseFile.Checked) selectedAttributes |= FileAttributes.SparseFile;
      if (checkBoxAttributeOffline.Checked) selectedAttributes |= FileAttributes.Offline;

      FileAttributes actualAttributes = fileInfo.Attributes;
      var selectedFlags = Enum.GetValues(typeof(FileAttributes)).Cast<FileAttributes>()
        .Where(attribute => attribute != FileAttributes.Normal && (selectedAttributes & attribute) == attribute)
        .ToArray();
      bool attributesMatch = radioButtonAttributesAll.Checked
        ? selectedFlags.All(attribute => (actualAttributes & attribute) == attribute)
        : selectedFlags.Any(attribute => (actualAttributes & attribute) == attribute);
      if (radioButtonAttributesOnly.Checked && actualAttributes != selectedAttributes)
      {
        attributesMatch = false;
      }
      if (checkBoxAttributes.Checked && !attributesMatch)
      {
        return false;
      }

      var file = fileInfo as FileInfo;
      string extension = file == null ? string.Empty : file.Extension.ToLowerInvariant();
      if (checkBoxSkipImageFiles.Checked &&
          new[] { ".bmp", ".gif", ".ico", ".jpeg", ".jpg", ".png", ".tif", ".tiff", ".webp" }.Contains(extension))
      {
        return false;
      }

      if (checkBoxSkipAudioFiles.Checked &&
          new[] { ".aac", ".flac", ".m4a", ".mp3", ".ogg", ".wav", ".wma" }.Contains(extension))
      {
        return false;
      }

      if (checkBoxSkipVideoFiles.Checked &&
          new[] { ".avi", ".m4v", ".mkv", ".mov", ".mp4", ".mpeg", ".mpg", ".wmv" }.Contains(extension))
      {
        return false;
      }

      return true;
    }

    private bool MatchesContainingText(FileSystemInfo fileInfo)
    {
      if (!(fileInfo is FileInfo))
      {
        return true;
      }

      string searchText = comboBoxSearchText.Text.Trim();
      if (searchText == string.Empty)
      {
        return true;
      }

      bool containsText;
      try
      {
        string content = File.ReadAllText(fileInfo.FullName);
        string[] searchTerms = comboBoxContainingTextMode.Text == "Words"
          ? searchText.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
          : new[] { searchText };

        var regexOptions = checkBoxCaseSensitive.Checked
          ? RegexOptions.None
          : RegexOptions.IgnoreCase;
        Func<string, bool> termMatches = term =>
        {
          string expression = Regex.Escape(term);
          if (checkBoxwholeWords.Checked)
          {
            expression = $"\\b{expression}\\b";
          }

          return Regex.IsMatch(content, expression, regexOptions);
        };

        containsText = radioButtonContainingTextMatchAll.Checked
          ? searchTerms.All(termMatches)
          : searchTerms.Any(termMatches);
      }
      catch (Exception exception) when (exception is IOException || exception is UnauthorizedAccessException || exception is DecoderFallbackException)
      {
        containsText = false;
      }

      return checkBoxWithout.Checked ? !containsText : containsText;
    }

    private static DateTime GetDateTime(DateTimePicker datePicker, NumericUpDown hour,
      NumericUpDown minute, NumericUpDown second)
    {
      return datePicker.Value.Date.AddHours((double)hour.Value)
        .AddMinutes((double)minute.Value).AddSeconds((double)second.Value);
    }

    private static bool MatchesDateFilter(DateTime fileDate, string operation,
      DateTime startDate, DateTime endDate)
    {
      switch (operation)
      {
        case "Not Between":
          return fileDate < startDate || fileDate > endDate;
        case "Newer than":
          return fileDate >= startDate;
        case "Older than":
          return fileDate <= startDate;
        case "Between":
        default:
          return fileDate >= startDate && fileDate <= endDate;
      }
    }

    private void ComboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
    {
      // code not yet implemented
    }

    private void ButtonStop_Click(object sender, EventArgs e)
    {
      _searchCancellationTokenSource?.Cancel();
    }

    private sealed class ListViewItemComparer : Comparer<ListViewItem>
    {
      private readonly int _column;
      private readonly bool _ascending;

      public ListViewItemComparer(int column, bool ascending)
      {
        _column = column;
        _ascending = ascending;
      }

      public override int Compare(ListViewItem leftItem, ListViewItem rightItem)
      {
        string leftText = leftItem.SubItems[_column].Text;
        string rightText = rightItem.SubItems[_column].Text;
        int result;

        if (_column == 0 || _column == 3)
        {
          long.TryParse(leftText.Replace(" ", string.Empty), NumberStyles.Integer,
            CultureInfo.InvariantCulture, out long leftValue);
          long.TryParse(rightText.Replace(" ", string.Empty), NumberStyles.Integer,
            CultureInfo.InvariantCulture, out long rightValue);
          result = leftValue.CompareTo(rightValue);
        }
        else if (_column >= 7)
        {
          DateTime.TryParse(leftText, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime leftValue);
          DateTime.TryParse(rightText, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime rightValue);
          result = leftValue.CompareTo(rightValue);
        }
        else
        {
          result = StringComparer.CurrentCultureIgnoreCase.Compare(leftText, rightText);
        }

        return _ascending ? result : -result;
      }
    }

    private void ButtonBrowsePath_Click(object sender, EventArgs e)
    {
      string selectedDirectory = PeekDirectory();
      if (string.IsNullOrEmpty(selectedDirectory))
      {
        return;
      }

      if (!comboBoxStartingFolder.Items.Contains(selectedDirectory))
      {
        comboBoxStartingFolder.Items.Add(selectedDirectory);
      }

      comboBoxStartingFolder.Text = selectedDirectory;
    }
  }
}