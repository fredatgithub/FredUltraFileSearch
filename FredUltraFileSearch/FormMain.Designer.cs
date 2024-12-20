﻿namespace FredUltraFileSearch
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("N°");
      System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Name");
      System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Folder");
      System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Size");
      System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Ext");
      System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Type");
      System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Attributes");
      System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Modified Date");
      System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Creation Date");
      System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Last Access Date");
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.personalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.languagetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.DisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.SmallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.LargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabControlMain = new System.Windows.Forms.TabControl();
      this.tabPageFilesAndFolders = new System.Windows.Forms.TabPage();
      this.panelMain = new System.Windows.Forms.Panel();
      this.comboBoxStartingFolder = new System.Windows.Forms.ComboBox();
      this.comboBoxFileName = new System.Windows.Forms.ComboBox();
      this.labelSelect = new System.Windows.Forms.Label();
      this.labelMode = new System.Windows.Forms.Label();
      this.comboBoxMode = new System.Windows.Forms.ComboBox();
      this.checkBoxShowFoldernames = new System.Windows.Forms.CheckBox();
      this.checkBoxShowFilenames = new System.Windows.Forms.CheckBox();
      this.checkBoxAppendResults = new System.Windows.Forms.CheckBox();
      this.checkBoxIncludeHiddenFolders = new System.Windows.Forms.CheckBox();
      this.buttonBrowsePath = new System.Windows.Forms.Button();
      this.labelStartingFolders = new System.Windows.Forms.Label();
      this.checkBoxScanInsubFolders = new System.Windows.Forms.CheckBox();
      this.labelFileNames = new System.Windows.Forms.Label();
      this.tabPageContaining = new System.Windows.Forms.TabPage();
      this.checkBoxCaseSensitive = new System.Windows.Forms.CheckBox();
      this.checkBoxwholeWords = new System.Windows.Forms.CheckBox();
      this.checkBoxWithout = new System.Windows.Forms.CheckBox();
      this.radioButtonContainingTextMatchAll = new System.Windows.Forms.RadioButton();
      this.radioButtonContainingTextMatchAny = new System.Windows.Forms.RadioButton();
      this.comboBoxSearchText = new System.Windows.Forms.ComboBox();
      this.labelContainingTextMode = new System.Windows.Forms.Label();
      this.comboBoxContainingTextMode = new System.Windows.Forms.ComboBox();
      this.checkBoxSkipAudioFiles = new System.Windows.Forms.CheckBox();
      this.checkBoxSkipImageFiles = new System.Windows.Forms.CheckBox();
      this.checkBoxSkipVideoFiles = new System.Windows.Forms.CheckBox();
      this.checkBoxSkipSystemFiles = new System.Windows.Forms.CheckBox();
      this.checkBoxSkipHiddenFiles = new System.Windows.Forms.CheckBox();
      this.labelSearchText = new System.Windows.Forms.Label();
      this.tabPageDateAndSize = new System.Windows.Forms.TabPage();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.numericUpDownSizeTo = new System.Windows.Forms.NumericUpDown();
      this.labelSizeAnd = new System.Windows.Forms.Label();
      this.comboBoxSizeMbKb = new System.Windows.Forms.ComboBox();
      this.numericUpDownSizeFrom = new System.Windows.Forms.NumericUpDown();
      this.comboBoxBetweenSize = new System.Windows.Forms.ComboBox();
      this.checkBoxSize = new System.Windows.Forms.CheckBox();
      this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown15 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownDateModifiedEndSecond = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownDateModifiedEndMinute = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownDateModifiedEndHour = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownDateCreationStartsecond = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownDateCreationStartMinute = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownDateCreationStartHour = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownDateModifiedStartSecond = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownDateModifiedStartMinute = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownDateModifiedStartHour = new System.Windows.Forms.NumericUpDown();
      this.dateTimePickerDateLastAccessEnd = new System.Windows.Forms.DateTimePicker();
      this.dateTimePickerDateCreationEnd = new System.Windows.Forms.DateTimePicker();
      this.dateTimePickerDateModifiedEnd = new System.Windows.Forms.DateTimePicker();
      this.labelAndDateLastAccess = new System.Windows.Forms.Label();
      this.labelAndDateCreation = new System.Windows.Forms.Label();
      this.labelAndDateModified = new System.Windows.Forms.Label();
      this.dateTimePickerDateLastAccessStart = new System.Windows.Forms.DateTimePicker();
      this.dateTimePickerDateCreationStart = new System.Windows.Forms.DateTimePicker();
      this.dateTimePickerDateModifiedStart = new System.Windows.Forms.DateTimePicker();
      this.comboBoxDateLastAccessBetween = new System.Windows.Forms.ComboBox();
      this.comboBoxDateCreationBetween = new System.Windows.Forms.ComboBox();
      this.comboBoxDateModifiedBetween = new System.Windows.Forms.ComboBox();
      this.checkBoxDateLastAccess = new System.Windows.Forms.CheckBox();
      this.checkBoxDateCreation = new System.Windows.Forms.CheckBox();
      this.checkBoxDateModified = new System.Windows.Forms.CheckBox();
      this.checkBoxDate = new System.Windows.Forms.CheckBox();
      this.tabPageAttributes = new System.Windows.Forms.TabPage();
      this.listViewResult = new System.Windows.Forms.ListView();
      this.buttonReset = new System.Windows.Forms.Button();
      this.buttonStop = new System.Windows.Forms.Button();
      this.buttonSearch = new System.Windows.Forms.Button();
      this.statusStripMain = new System.Windows.Forms.StatusStrip();
      this.menuStrip1.SuspendLayout();
      this.tabControlMain.SuspendLayout();
      this.tabPageFilesAndFolders.SuspendLayout();
      this.panelMain.SuspendLayout();
      this.tabPageContaining.SuspendLayout();
      this.tabPageDateAndSize.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeTo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeFrom)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateModifiedEndSecond)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateModifiedEndMinute)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateModifiedEndHour)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateCreationStartsecond)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateCreationStartMinute)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateCreationStartHour)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateModifiedStartSecond)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateModifiedStartMinute)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateModifiedStartHour)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.languagetoolStripMenuItem,
            this.DisplayToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(1109, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
      this.fileToolStripMenuItem.Text = "&Fichier";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.newToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.newToolStripMenuItem.Text = "&Nouveau";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.openToolStripMenuItem.Text = "&Ouvrir";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(202, 6);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.saveToolStripMenuItem.Text = "&Enregistrer";
      // 
      // saveasToolStripMenuItem
      // 
      this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
      this.saveasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.saveasToolStripMenuItem.Text = "Enregistrer &sous";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
      // 
      // printToolStripMenuItem
      // 
      this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printToolStripMenuItem.Name = "printToolStripMenuItem";
      this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.printToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.printToolStripMenuItem.Text = "&Imprimer";
      // 
      // printPreviewToolStripMenuItem
      // 
      this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
      this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.printPreviewToolStripMenuItem.Text = "Aperçu a&vant impression";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
      // 
      // quitToolStripMenuItem
      // 
      this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
      this.quitToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.quitToolStripMenuItem.Text = "&Quitter";
      this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
      this.editToolStripMenuItem.Text = "&Edition";
      // 
      // cancelToolStripMenuItem
      // 
      this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
      this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.cancelToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.cancelToolStripMenuItem.Text = "&Annuler";
      // 
      // redoToolStripMenuItem
      // 
      this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
      this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.redoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.redoToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
      // 
      // cutToolStripMenuItem
      // 
      this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
      this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.cutToolStripMenuItem.Text = "&Couper";
      this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.copyToolStripMenuItem.Text = "Co&pier";
      this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
      // 
      // pasteToolStripMenuItem
      // 
      this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.pasteToolStripMenuItem.Text = "Co&ller";
      this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
      // 
      // selectAllToolStripMenuItem
      // 
      this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
      this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.selectAllToolStripMenuItem.Text = "Sélectio&nner tout";
      this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
      // 
      // toolsToolStripMenuItem
      // 
      this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.toolsToolStripMenuItem.Text = "&Outils";
      // 
      // personalizeToolStripMenuItem
      // 
      this.personalizeToolStripMenuItem.Name = "personalizeToolStripMenuItem";
      this.personalizeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.personalizeToolStripMenuItem.Text = "&Personnaliser";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.optionsToolStripMenuItem.Text = "&Options";
      this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
      // 
      // languagetoolStripMenuItem
      // 
      this.languagetoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frenchToolStripMenuItem,
            this.englishToolStripMenuItem});
      this.languagetoolStripMenuItem.Name = "languagetoolStripMenuItem";
      this.languagetoolStripMenuItem.Size = new System.Drawing.Size(71, 20);
      this.languagetoolStripMenuItem.Text = "Language";
      // 
      // frenchToolStripMenuItem
      // 
      this.frenchToolStripMenuItem.Checked = true;
      this.frenchToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
      this.frenchToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
      this.frenchToolStripMenuItem.Text = "Français";
      this.frenchToolStripMenuItem.Click += new System.EventHandler(this.FrenchToolStripMenuItem_Click);
      // 
      // englishToolStripMenuItem
      // 
      this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
      this.englishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
      this.englishToolStripMenuItem.Text = "Anglais";
      this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
      // 
      // DisplayToolStripMenuItem
      // 
      this.DisplayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmallToolStripMenuItem,
            this.MediumToolStripMenuItem,
            this.LargeToolStripMenuItem});
      this.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem";
      this.DisplayToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
      this.DisplayToolStripMenuItem.Text = "Affichage";
      // 
      // SmallToolStripMenuItem
      // 
      this.SmallToolStripMenuItem.Checked = true;
      this.SmallToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.SmallToolStripMenuItem.Name = "SmallToolStripMenuItem";
      this.SmallToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
      this.SmallToolStripMenuItem.Text = "Petit";
      this.SmallToolStripMenuItem.Click += new System.EventHandler(this.SmallToolStripMenuItem_Click);
      // 
      // MediumToolStripMenuItem
      // 
      this.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem";
      this.MediumToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
      this.MediumToolStripMenuItem.Text = "Moyen";
      this.MediumToolStripMenuItem.Click += new System.EventHandler(this.MediumToolStripMenuItem_Click);
      // 
      // LargeToolStripMenuItem
      // 
      this.LargeToolStripMenuItem.Name = "LargeToolStripMenuItem";
      this.LargeToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
      this.LargeToolStripMenuItem.Text = "Grand";
      this.LargeToolStripMenuItem.Click += new System.EventHandler(this.LargeToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.helpToolStripMenuItem.Text = "&Aide";
      // 
      // summaryToolStripMenuItem
      // 
      this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
      this.summaryToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.summaryToolStripMenuItem.Text = "&Sommaire";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // searchToolStripMenuItem
      // 
      this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
      this.searchToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.searchToolStripMenuItem.Text = "&Rechercher";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(144, 6);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.aboutToolStripMenuItem.Text = "À &propos de...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
      // 
      // tabControlMain
      // 
      this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControlMain.Controls.Add(this.tabPageFilesAndFolders);
      this.tabControlMain.Controls.Add(this.tabPageContaining);
      this.tabControlMain.Controls.Add(this.tabPageDateAndSize);
      this.tabControlMain.Controls.Add(this.tabPageAttributes);
      this.tabControlMain.Location = new System.Drawing.Point(0, 24);
      this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
      this.tabControlMain.Name = "tabControlMain";
      this.tabControlMain.SelectedIndex = 0;
      this.tabControlMain.Size = new System.Drawing.Size(1004, 242);
      this.tabControlMain.TabIndex = 2;
      // 
      // tabPageFilesAndFolders
      // 
      this.tabPageFilesAndFolders.Controls.Add(this.panelMain);
      this.tabPageFilesAndFolders.Location = new System.Drawing.Point(4, 22);
      this.tabPageFilesAndFolders.Margin = new System.Windows.Forms.Padding(2);
      this.tabPageFilesAndFolders.Name = "tabPageFilesAndFolders";
      this.tabPageFilesAndFolders.Padding = new System.Windows.Forms.Padding(2);
      this.tabPageFilesAndFolders.Size = new System.Drawing.Size(996, 216);
      this.tabPageFilesAndFolders.TabIndex = 1;
      this.tabPageFilesAndFolders.Text = "Files and Folders";
      this.tabPageFilesAndFolders.UseVisualStyleBackColor = true;
      // 
      // panelMain
      // 
      this.panelMain.Controls.Add(this.comboBoxStartingFolder);
      this.panelMain.Controls.Add(this.comboBoxFileName);
      this.panelMain.Controls.Add(this.labelSelect);
      this.panelMain.Controls.Add(this.labelMode);
      this.panelMain.Controls.Add(this.comboBoxMode);
      this.panelMain.Controls.Add(this.checkBoxShowFoldernames);
      this.panelMain.Controls.Add(this.checkBoxShowFilenames);
      this.panelMain.Controls.Add(this.checkBoxAppendResults);
      this.panelMain.Controls.Add(this.checkBoxIncludeHiddenFolders);
      this.panelMain.Controls.Add(this.buttonBrowsePath);
      this.panelMain.Controls.Add(this.labelStartingFolders);
      this.panelMain.Controls.Add(this.checkBoxScanInsubFolders);
      this.panelMain.Controls.Add(this.labelFileNames);
      this.panelMain.Location = new System.Drawing.Point(2, 2);
      this.panelMain.Margin = new System.Windows.Forms.Padding(2);
      this.panelMain.Name = "panelMain";
      this.panelMain.Size = new System.Drawing.Size(990, 207);
      this.panelMain.TabIndex = 4;
      // 
      // comboBoxStartingFolder
      // 
      this.comboBoxStartingFolder.FormattingEnabled = true;
      this.comboBoxStartingFolder.Location = new System.Drawing.Point(16, 97);
      this.comboBoxStartingFolder.Name = "comboBoxStartingFolder";
      this.comboBoxStartingFolder.Size = new System.Drawing.Size(448, 21);
      this.comboBoxStartingFolder.TabIndex = 16;
      // 
      // comboBoxFileName
      // 
      this.comboBoxFileName.FormattingEnabled = true;
      this.comboBoxFileName.Location = new System.Drawing.Point(16, 45);
      this.comboBoxFileName.Name = "comboBoxFileName";
      this.comboBoxFileName.Size = new System.Drawing.Size(448, 21);
      this.comboBoxFileName.TabIndex = 15;
      // 
      // labelSelect
      // 
      this.labelSelect.AutoSize = true;
      this.labelSelect.Location = new System.Drawing.Point(484, 79);
      this.labelSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelSelect.Name = "labelSelect";
      this.labelSelect.Size = new System.Drawing.Size(37, 13);
      this.labelSelect.TabIndex = 14;
      this.labelSelect.Text = "Select";
      // 
      // labelMode
      // 
      this.labelMode.AutoSize = true;
      this.labelMode.Location = new System.Drawing.Point(484, 24);
      this.labelMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelMode.Name = "labelMode";
      this.labelMode.Size = new System.Drawing.Size(34, 13);
      this.labelMode.TabIndex = 13;
      this.labelMode.Text = "Mode";
      // 
      // comboBoxMode
      // 
      this.comboBoxMode.BackColor = System.Drawing.SystemColors.ControlDark;
      this.comboBoxMode.FormattingEnabled = true;
      this.comboBoxMode.Items.AddRange(new object[] {
            "Simple",
            "Wildcards"});
      this.comboBoxMode.Location = new System.Drawing.Point(487, 45);
      this.comboBoxMode.Margin = new System.Windows.Forms.Padding(2);
      this.comboBoxMode.Name = "comboBoxMode";
      this.comboBoxMode.Size = new System.Drawing.Size(92, 21);
      this.comboBoxMode.TabIndex = 12;
      this.comboBoxMode.Text = "Simple";
      this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMode_SelectedIndexChanged);
      // 
      // checkBoxShowFoldernames
      // 
      this.checkBoxShowFoldernames.AutoSize = true;
      this.checkBoxShowFoldernames.Checked = true;
      this.checkBoxShowFoldernames.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxShowFoldernames.Location = new System.Drawing.Point(174, 169);
      this.checkBoxShowFoldernames.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxShowFoldernames.Name = "checkBoxShowFoldernames";
      this.checkBoxShowFoldernames.Size = new System.Drawing.Size(116, 17);
      this.checkBoxShowFoldernames.TabIndex = 11;
      this.checkBoxShowFoldernames.Text = "Show Foldernames";
      this.checkBoxShowFoldernames.UseVisualStyleBackColor = true;
      // 
      // checkBoxShowFilenames
      // 
      this.checkBoxShowFilenames.AutoSize = true;
      this.checkBoxShowFilenames.Checked = true;
      this.checkBoxShowFilenames.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxShowFilenames.Location = new System.Drawing.Point(16, 169);
      this.checkBoxShowFilenames.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxShowFilenames.Name = "checkBoxShowFilenames";
      this.checkBoxShowFilenames.Size = new System.Drawing.Size(103, 17);
      this.checkBoxShowFilenames.TabIndex = 10;
      this.checkBoxShowFilenames.Text = "Show Filenames";
      this.checkBoxShowFilenames.UseVisualStyleBackColor = true;
      // 
      // checkBoxAppendResults
      // 
      this.checkBoxAppendResults.AutoSize = true;
      this.checkBoxAppendResults.Location = new System.Drawing.Point(337, 169);
      this.checkBoxAppendResults.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxAppendResults.Name = "checkBoxAppendResults";
      this.checkBoxAppendResults.Size = new System.Drawing.Size(101, 17);
      this.checkBoxAppendResults.TabIndex = 9;
      this.checkBoxAppendResults.Text = "Append Results";
      this.checkBoxAppendResults.UseVisualStyleBackColor = true;
      // 
      // checkBoxIncludeHiddenFolders
      // 
      this.checkBoxIncludeHiddenFolders.AutoSize = true;
      this.checkBoxIncludeHiddenFolders.Checked = true;
      this.checkBoxIncludeHiddenFolders.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxIncludeHiddenFolders.Location = new System.Drawing.Point(174, 135);
      this.checkBoxIncludeHiddenFolders.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxIncludeHiddenFolders.Name = "checkBoxIncludeHiddenFolders";
      this.checkBoxIncludeHiddenFolders.Size = new System.Drawing.Size(135, 17);
      this.checkBoxIncludeHiddenFolders.TabIndex = 8;
      this.checkBoxIncludeHiddenFolders.Text = "Include Hidden Folders";
      this.checkBoxIncludeHiddenFolders.UseVisualStyleBackColor = true;
      // 
      // buttonBrowsePath
      // 
      this.buttonBrowsePath.Location = new System.Drawing.Point(487, 98);
      this.buttonBrowsePath.Margin = new System.Windows.Forms.Padding(2);
      this.buttonBrowsePath.Name = "buttonBrowsePath";
      this.buttonBrowsePath.Size = new System.Drawing.Size(91, 20);
      this.buttonBrowsePath.TabIndex = 7;
      this.buttonBrowsePath.Text = "Browse ...";
      this.buttonBrowsePath.UseVisualStyleBackColor = true;
      // 
      // labelStartingFolders
      // 
      this.labelStartingFolders.AutoSize = true;
      this.labelStartingFolders.Location = new System.Drawing.Point(13, 79);
      this.labelStartingFolders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelStartingFolders.Name = "labelStartingFolders";
      this.labelStartingFolders.Size = new System.Drawing.Size(66, 13);
      this.labelStartingFolders.TabIndex = 4;
      this.labelStartingFolders.Text = "Search Path";
      // 
      // checkBoxScanInsubFolders
      // 
      this.checkBoxScanInsubFolders.AutoSize = true;
      this.checkBoxScanInsubFolders.Checked = true;
      this.checkBoxScanInsubFolders.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxScanInsubFolders.Location = new System.Drawing.Point(16, 135);
      this.checkBoxScanInsubFolders.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxScanInsubFolders.Name = "checkBoxScanInsubFolders";
      this.checkBoxScanInsubFolders.Size = new System.Drawing.Size(124, 17);
      this.checkBoxScanInsubFolders.TabIndex = 6;
      this.checkBoxScanInsubFolders.Text = "Search in Subfolders";
      this.checkBoxScanInsubFolders.UseVisualStyleBackColor = true;
      // 
      // labelFileNames
      // 
      this.labelFileNames.AutoSize = true;
      this.labelFileNames.Location = new System.Drawing.Point(13, 17);
      this.labelFileNames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelFileNames.Name = "labelFileNames";
      this.labelFileNames.Size = new System.Drawing.Size(54, 13);
      this.labelFileNames.TabIndex = 0;
      this.labelFileNames.Text = "File Name";
      // 
      // tabPageContaining
      // 
      this.tabPageContaining.Controls.Add(this.checkBoxCaseSensitive);
      this.tabPageContaining.Controls.Add(this.checkBoxwholeWords);
      this.tabPageContaining.Controls.Add(this.checkBoxWithout);
      this.tabPageContaining.Controls.Add(this.radioButtonContainingTextMatchAll);
      this.tabPageContaining.Controls.Add(this.radioButtonContainingTextMatchAny);
      this.tabPageContaining.Controls.Add(this.comboBoxSearchText);
      this.tabPageContaining.Controls.Add(this.labelContainingTextMode);
      this.tabPageContaining.Controls.Add(this.comboBoxContainingTextMode);
      this.tabPageContaining.Controls.Add(this.checkBoxSkipAudioFiles);
      this.tabPageContaining.Controls.Add(this.checkBoxSkipImageFiles);
      this.tabPageContaining.Controls.Add(this.checkBoxSkipVideoFiles);
      this.tabPageContaining.Controls.Add(this.checkBoxSkipSystemFiles);
      this.tabPageContaining.Controls.Add(this.checkBoxSkipHiddenFiles);
      this.tabPageContaining.Controls.Add(this.labelSearchText);
      this.tabPageContaining.Location = new System.Drawing.Point(4, 22);
      this.tabPageContaining.Margin = new System.Windows.Forms.Padding(2);
      this.tabPageContaining.Name = "tabPageContaining";
      this.tabPageContaining.Size = new System.Drawing.Size(996, 216);
      this.tabPageContaining.TabIndex = 2;
      this.tabPageContaining.Text = "Containing Text";
      this.tabPageContaining.UseVisualStyleBackColor = true;
      // 
      // checkBoxCaseSensitive
      // 
      this.checkBoxCaseSensitive.AutoSize = true;
      this.checkBoxCaseSensitive.Checked = true;
      this.checkBoxCaseSensitive.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxCaseSensitive.Location = new System.Drawing.Point(352, 90);
      this.checkBoxCaseSensitive.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxCaseSensitive.Name = "checkBoxCaseSensitive";
      this.checkBoxCaseSensitive.Size = new System.Drawing.Size(96, 17);
      this.checkBoxCaseSensitive.TabIndex = 29;
      this.checkBoxCaseSensitive.Text = "Case Sensitive";
      this.checkBoxCaseSensitive.UseVisualStyleBackColor = true;
      // 
      // checkBoxwholeWords
      // 
      this.checkBoxwholeWords.AutoSize = true;
      this.checkBoxwholeWords.Checked = true;
      this.checkBoxwholeWords.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxwholeWords.Location = new System.Drawing.Point(194, 90);
      this.checkBoxwholeWords.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxwholeWords.Name = "checkBoxwholeWords";
      this.checkBoxwholeWords.Size = new System.Drawing.Size(91, 17);
      this.checkBoxwholeWords.TabIndex = 28;
      this.checkBoxwholeWords.Text = "Whole Words";
      this.checkBoxwholeWords.UseVisualStyleBackColor = true;
      // 
      // checkBoxWithout
      // 
      this.checkBoxWithout.AutoSize = true;
      this.checkBoxWithout.Location = new System.Drawing.Point(515, 90);
      this.checkBoxWithout.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxWithout.Name = "checkBoxWithout";
      this.checkBoxWithout.Size = new System.Drawing.Size(63, 17);
      this.checkBoxWithout.TabIndex = 27;
      this.checkBoxWithout.Text = "Without";
      this.checkBoxWithout.UseVisualStyleBackColor = true;
      // 
      // radioButtonContainingTextMatchAll
      // 
      this.radioButtonContainingTextMatchAll.AutoSize = true;
      this.radioButtonContainingTextMatchAll.Location = new System.Drawing.Point(113, 89);
      this.radioButtonContainingTextMatchAll.Name = "radioButtonContainingTextMatchAll";
      this.radioButtonContainingTextMatchAll.Size = new System.Drawing.Size(69, 17);
      this.radioButtonContainingTextMatchAll.TabIndex = 26;
      this.radioButtonContainingTextMatchAll.Text = "Match All";
      this.radioButtonContainingTextMatchAll.UseVisualStyleBackColor = true;
      // 
      // radioButtonContainingTextMatchAny
      // 
      this.radioButtonContainingTextMatchAny.AutoSize = true;
      this.radioButtonContainingTextMatchAny.Checked = true;
      this.radioButtonContainingTextMatchAny.Location = new System.Drawing.Point(31, 89);
      this.radioButtonContainingTextMatchAny.Name = "radioButtonContainingTextMatchAny";
      this.radioButtonContainingTextMatchAny.Size = new System.Drawing.Size(76, 17);
      this.radioButtonContainingTextMatchAny.TabIndex = 25;
      this.radioButtonContainingTextMatchAny.TabStop = true;
      this.radioButtonContainingTextMatchAny.Text = "Match Any";
      this.radioButtonContainingTextMatchAny.UseVisualStyleBackColor = true;
      // 
      // comboBoxSearchText
      // 
      this.comboBoxSearchText.FormattingEnabled = true;
      this.comboBoxSearchText.Location = new System.Drawing.Point(31, 52);
      this.comboBoxSearchText.Name = "comboBoxSearchText";
      this.comboBoxSearchText.Size = new System.Drawing.Size(448, 21);
      this.comboBoxSearchText.TabIndex = 24;
      // 
      // labelContainingTextMode
      // 
      this.labelContainingTextMode.AutoSize = true;
      this.labelContainingTextMode.Location = new System.Drawing.Point(499, 31);
      this.labelContainingTextMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelContainingTextMode.Name = "labelContainingTextMode";
      this.labelContainingTextMode.Size = new System.Drawing.Size(34, 13);
      this.labelContainingTextMode.TabIndex = 23;
      this.labelContainingTextMode.Text = "Mode";
      // 
      // comboBoxContainingTextMode
      // 
      this.comboBoxContainingTextMode.BackColor = System.Drawing.SystemColors.ControlDark;
      this.comboBoxContainingTextMode.FormattingEnabled = true;
      this.comboBoxContainingTextMode.Items.AddRange(new object[] {
            "Words",
            "Phrases"});
      this.comboBoxContainingTextMode.Location = new System.Drawing.Point(502, 52);
      this.comboBoxContainingTextMode.Margin = new System.Windows.Forms.Padding(2);
      this.comboBoxContainingTextMode.Name = "comboBoxContainingTextMode";
      this.comboBoxContainingTextMode.Size = new System.Drawing.Size(92, 21);
      this.comboBoxContainingTextMode.TabIndex = 22;
      this.comboBoxContainingTextMode.Text = "Words";
      // 
      // checkBoxSkipAudioFiles
      // 
      this.checkBoxSkipAudioFiles.AutoSize = true;
      this.checkBoxSkipAudioFiles.Checked = true;
      this.checkBoxSkipAudioFiles.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxSkipAudioFiles.Location = new System.Drawing.Point(194, 156);
      this.checkBoxSkipAudioFiles.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxSkipAudioFiles.Name = "checkBoxSkipAudioFiles";
      this.checkBoxSkipAudioFiles.Size = new System.Drawing.Size(98, 17);
      this.checkBoxSkipAudioFiles.TabIndex = 21;
      this.checkBoxSkipAudioFiles.Text = "Skip Audio files";
      this.checkBoxSkipAudioFiles.UseVisualStyleBackColor = true;
      // 
      // checkBoxSkipImageFiles
      // 
      this.checkBoxSkipImageFiles.AutoSize = true;
      this.checkBoxSkipImageFiles.Checked = true;
      this.checkBoxSkipImageFiles.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxSkipImageFiles.Location = new System.Drawing.Point(29, 156);
      this.checkBoxSkipImageFiles.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxSkipImageFiles.Name = "checkBoxSkipImageFiles";
      this.checkBoxSkipImageFiles.Size = new System.Drawing.Size(103, 17);
      this.checkBoxSkipImageFiles.TabIndex = 20;
      this.checkBoxSkipImageFiles.Text = "Skip Image Files";
      this.checkBoxSkipImageFiles.UseVisualStyleBackColor = true;
      // 
      // checkBoxSkipVideoFiles
      // 
      this.checkBoxSkipVideoFiles.AutoSize = true;
      this.checkBoxSkipVideoFiles.Checked = true;
      this.checkBoxSkipVideoFiles.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxSkipVideoFiles.Location = new System.Drawing.Point(350, 156);
      this.checkBoxSkipVideoFiles.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxSkipVideoFiles.Name = "checkBoxSkipVideoFiles";
      this.checkBoxSkipVideoFiles.Size = new System.Drawing.Size(101, 17);
      this.checkBoxSkipVideoFiles.TabIndex = 19;
      this.checkBoxSkipVideoFiles.Text = "Skip Video Files";
      this.checkBoxSkipVideoFiles.UseVisualStyleBackColor = true;
      // 
      // checkBoxSkipSystemFiles
      // 
      this.checkBoxSkipSystemFiles.AutoSize = true;
      this.checkBoxSkipSystemFiles.Checked = true;
      this.checkBoxSkipSystemFiles.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxSkipSystemFiles.Location = new System.Drawing.Point(194, 122);
      this.checkBoxSkipSystemFiles.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxSkipSystemFiles.Name = "checkBoxSkipSystemFiles";
      this.checkBoxSkipSystemFiles.Size = new System.Drawing.Size(108, 17);
      this.checkBoxSkipSystemFiles.TabIndex = 18;
      this.checkBoxSkipSystemFiles.Text = "Skip System Files";
      this.checkBoxSkipSystemFiles.UseVisualStyleBackColor = true;
      // 
      // checkBoxSkipHiddenFiles
      // 
      this.checkBoxSkipHiddenFiles.AutoSize = true;
      this.checkBoxSkipHiddenFiles.Checked = true;
      this.checkBoxSkipHiddenFiles.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxSkipHiddenFiles.Location = new System.Drawing.Point(29, 122);
      this.checkBoxSkipHiddenFiles.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxSkipHiddenFiles.Name = "checkBoxSkipHiddenFiles";
      this.checkBoxSkipHiddenFiles.Size = new System.Drawing.Size(108, 17);
      this.checkBoxSkipHiddenFiles.TabIndex = 17;
      this.checkBoxSkipHiddenFiles.Text = "Skip Hidden Files";
      this.checkBoxSkipHiddenFiles.UseVisualStyleBackColor = true;
      // 
      // labelSearchText
      // 
      this.labelSearchText.AutoSize = true;
      this.labelSearchText.Location = new System.Drawing.Point(28, 24);
      this.labelSearchText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelSearchText.Name = "labelSearchText";
      this.labelSearchText.Size = new System.Drawing.Size(65, 13);
      this.labelSearchText.TabIndex = 16;
      this.labelSearchText.Text = "Search Text";
      // 
      // tabPageDateAndSize
      // 
      this.tabPageDateAndSize.Controls.Add(this.comboBox1);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDownSizeTo);
      this.tabPageDateAndSize.Controls.Add(this.labelSizeAnd);
      this.tabPageDateAndSize.Controls.Add(this.comboBoxSizeMbKb);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDownSizeFrom);
      this.tabPageDateAndSize.Controls.Add(this.comboBoxBetweenSize);
      this.tabPageDateAndSize.Controls.Add(this.checkBoxSize);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDown13);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDown14);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDown15);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDown10);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDown11);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDown12);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDownDateModifiedEndSecond);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDownDateModifiedEndMinute);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDownDateModifiedEndHour);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDown4);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDown5);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDown6);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDownDateCreationStartsecond);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDownDateCreationStartMinute);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDownDateCreationStartHour);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDownDateModifiedStartSecond);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDownDateModifiedStartMinute);
      this.tabPageDateAndSize.Controls.Add(this.numericUpDownDateModifiedStartHour);
      this.tabPageDateAndSize.Controls.Add(this.dateTimePickerDateLastAccessEnd);
      this.tabPageDateAndSize.Controls.Add(this.dateTimePickerDateCreationEnd);
      this.tabPageDateAndSize.Controls.Add(this.dateTimePickerDateModifiedEnd);
      this.tabPageDateAndSize.Controls.Add(this.labelAndDateLastAccess);
      this.tabPageDateAndSize.Controls.Add(this.labelAndDateCreation);
      this.tabPageDateAndSize.Controls.Add(this.labelAndDateModified);
      this.tabPageDateAndSize.Controls.Add(this.dateTimePickerDateLastAccessStart);
      this.tabPageDateAndSize.Controls.Add(this.dateTimePickerDateCreationStart);
      this.tabPageDateAndSize.Controls.Add(this.dateTimePickerDateModifiedStart);
      this.tabPageDateAndSize.Controls.Add(this.comboBoxDateLastAccessBetween);
      this.tabPageDateAndSize.Controls.Add(this.comboBoxDateCreationBetween);
      this.tabPageDateAndSize.Controls.Add(this.comboBoxDateModifiedBetween);
      this.tabPageDateAndSize.Controls.Add(this.checkBoxDateLastAccess);
      this.tabPageDateAndSize.Controls.Add(this.checkBoxDateCreation);
      this.tabPageDateAndSize.Controls.Add(this.checkBoxDateModified);
      this.tabPageDateAndSize.Controls.Add(this.checkBoxDate);
      this.tabPageDateAndSize.Location = new System.Drawing.Point(4, 22);
      this.tabPageDateAndSize.Margin = new System.Windows.Forms.Padding(2);
      this.tabPageDateAndSize.Name = "tabPageDateAndSize";
      this.tabPageDateAndSize.Size = new System.Drawing.Size(996, 216);
      this.tabPageDateAndSize.TabIndex = 3;
      this.tabPageDateAndSize.Text = "Date and Size";
      this.tabPageDateAndSize.UseVisualStyleBackColor = true;
      // 
      // comboBox1
      // 
      this.comboBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.comboBox1.Enabled = false;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "GB",
            "MB",
            "KB",
            "Bytes"});
      this.comboBox1.Location = new System.Drawing.Point(637, 181);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(77, 21);
      this.comboBox1.TabIndex = 59;
      this.comboBox1.Text = "KB";
      // 
      // numericUpDownSizeTo
      // 
      this.numericUpDownSizeTo.Enabled = false;
      this.numericUpDownSizeTo.Location = new System.Drawing.Point(520, 182);
      this.numericUpDownSizeTo.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
      this.numericUpDownSizeTo.Name = "numericUpDownSizeTo";
      this.numericUpDownSizeTo.Size = new System.Drawing.Size(80, 20);
      this.numericUpDownSizeTo.TabIndex = 58;
      // 
      // labelSizeAnd
      // 
      this.labelSizeAnd.AutoSize = true;
      this.labelSizeAnd.Location = new System.Drawing.Point(483, 184);
      this.labelSizeAnd.Name = "labelSizeAnd";
      this.labelSizeAnd.Size = new System.Drawing.Size(25, 13);
      this.labelSizeAnd.TabIndex = 57;
      this.labelSizeAnd.Text = "and";
      // 
      // comboBoxSizeMbKb
      // 
      this.comboBoxSizeMbKb.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.comboBoxSizeMbKb.Enabled = false;
      this.comboBoxSizeMbKb.FormattingEnabled = true;
      this.comboBoxSizeMbKb.Items.AddRange(new object[] {
            "GB",
            "MB",
            "KB",
            "Bytes"});
      this.comboBoxSizeMbKb.Location = new System.Drawing.Point(397, 181);
      this.comboBoxSizeMbKb.Name = "comboBoxSizeMbKb";
      this.comboBoxSizeMbKb.Size = new System.Drawing.Size(77, 21);
      this.comboBoxSizeMbKb.TabIndex = 56;
      this.comboBoxSizeMbKb.Text = "KB";
      // 
      // numericUpDownSizeFrom
      // 
      this.numericUpDownSizeFrom.Enabled = false;
      this.numericUpDownSizeFrom.Location = new System.Drawing.Point(296, 184);
      this.numericUpDownSizeFrom.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
      this.numericUpDownSizeFrom.Name = "numericUpDownSizeFrom";
      this.numericUpDownSizeFrom.Size = new System.Drawing.Size(80, 20);
      this.numericUpDownSizeFrom.TabIndex = 55;
      // 
      // comboBoxBetweenSize
      // 
      this.comboBoxBetweenSize.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.comboBoxBetweenSize.Enabled = false;
      this.comboBoxBetweenSize.FormattingEnabled = true;
      this.comboBoxBetweenSize.Items.AddRange(new object[] {
            "Between",
            "Not Between",
            "Newer than",
            "Older than"});
      this.comboBoxBetweenSize.Location = new System.Drawing.Point(156, 183);
      this.comboBoxBetweenSize.Name = "comboBoxBetweenSize";
      this.comboBoxBetweenSize.Size = new System.Drawing.Size(121, 21);
      this.comboBoxBetweenSize.TabIndex = 54;
      this.comboBoxBetweenSize.Text = "Between";
      // 
      // checkBoxSize
      // 
      this.checkBoxSize.AutoSize = true;
      this.checkBoxSize.Location = new System.Drawing.Point(22, 183);
      this.checkBoxSize.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxSize.Name = "checkBoxSize";
      this.checkBoxSize.Size = new System.Drawing.Size(46, 17);
      this.checkBoxSize.TabIndex = 53;
      this.checkBoxSize.Text = "Size";
      this.checkBoxSize.UseVisualStyleBackColor = true;
      // 
      // numericUpDown13
      // 
      this.numericUpDown13.Enabled = false;
      this.numericUpDown13.Location = new System.Drawing.Point(913, 116);
      this.numericUpDown13.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numericUpDown13.Name = "numericUpDown13";
      this.numericUpDown13.Size = new System.Drawing.Size(35, 20);
      this.numericUpDown13.TabIndex = 52;
      // 
      // numericUpDown14
      // 
      this.numericUpDown14.Enabled = false;
      this.numericUpDown14.Location = new System.Drawing.Point(872, 116);
      this.numericUpDown14.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numericUpDown14.Name = "numericUpDown14";
      this.numericUpDown14.Size = new System.Drawing.Size(35, 20);
      this.numericUpDown14.TabIndex = 51;
      // 
      // numericUpDown15
      // 
      this.numericUpDown15.Enabled = false;
      this.numericUpDown15.Location = new System.Drawing.Point(831, 116);
      this.numericUpDown15.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
      this.numericUpDown15.Name = "numericUpDown15";
      this.numericUpDown15.Size = new System.Drawing.Size(35, 20);
      this.numericUpDown15.TabIndex = 50;
      // 
      // numericUpDown10
      // 
      this.numericUpDown10.Enabled = false;
      this.numericUpDown10.Location = new System.Drawing.Point(913, 84);
      this.numericUpDown10.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numericUpDown10.Name = "numericUpDown10";
      this.numericUpDown10.Size = new System.Drawing.Size(35, 20);
      this.numericUpDown10.TabIndex = 49;
      // 
      // numericUpDown11
      // 
      this.numericUpDown11.Enabled = false;
      this.numericUpDown11.Location = new System.Drawing.Point(872, 84);
      this.numericUpDown11.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numericUpDown11.Name = "numericUpDown11";
      this.numericUpDown11.Size = new System.Drawing.Size(35, 20);
      this.numericUpDown11.TabIndex = 48;
      // 
      // numericUpDown12
      // 
      this.numericUpDown12.Enabled = false;
      this.numericUpDown12.Location = new System.Drawing.Point(831, 84);
      this.numericUpDown12.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
      this.numericUpDown12.Name = "numericUpDown12";
      this.numericUpDown12.Size = new System.Drawing.Size(35, 20);
      this.numericUpDown12.TabIndex = 47;
      // 
      // numericUpDownDateModifiedEndSecond
      // 
      this.numericUpDownDateModifiedEndSecond.Enabled = false;
      this.numericUpDownDateModifiedEndSecond.Location = new System.Drawing.Point(913, 50);
      this.numericUpDownDateModifiedEndSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numericUpDownDateModifiedEndSecond.Name = "numericUpDownDateModifiedEndSecond";
      this.numericUpDownDateModifiedEndSecond.Size = new System.Drawing.Size(35, 20);
      this.numericUpDownDateModifiedEndSecond.TabIndex = 46;
      // 
      // numericUpDownDateModifiedEndMinute
      // 
      this.numericUpDownDateModifiedEndMinute.Enabled = false;
      this.numericUpDownDateModifiedEndMinute.Location = new System.Drawing.Point(872, 50);
      this.numericUpDownDateModifiedEndMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numericUpDownDateModifiedEndMinute.Name = "numericUpDownDateModifiedEndMinute";
      this.numericUpDownDateModifiedEndMinute.Size = new System.Drawing.Size(35, 20);
      this.numericUpDownDateModifiedEndMinute.TabIndex = 45;
      // 
      // numericUpDownDateModifiedEndHour
      // 
      this.numericUpDownDateModifiedEndHour.Enabled = false;
      this.numericUpDownDateModifiedEndHour.Location = new System.Drawing.Point(831, 50);
      this.numericUpDownDateModifiedEndHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
      this.numericUpDownDateModifiedEndHour.Name = "numericUpDownDateModifiedEndHour";
      this.numericUpDownDateModifiedEndHour.Size = new System.Drawing.Size(35, 20);
      this.numericUpDownDateModifiedEndHour.TabIndex = 44;
      // 
      // numericUpDown4
      // 
      this.numericUpDown4.Enabled = false;
      this.numericUpDown4.Location = new System.Drawing.Point(565, 116);
      this.numericUpDown4.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numericUpDown4.Name = "numericUpDown4";
      this.numericUpDown4.Size = new System.Drawing.Size(35, 20);
      this.numericUpDown4.TabIndex = 43;
      // 
      // numericUpDown5
      // 
      this.numericUpDown5.Enabled = false;
      this.numericUpDown5.Location = new System.Drawing.Point(524, 116);
      this.numericUpDown5.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numericUpDown5.Name = "numericUpDown5";
      this.numericUpDown5.Size = new System.Drawing.Size(35, 20);
      this.numericUpDown5.TabIndex = 42;
      // 
      // numericUpDown6
      // 
      this.numericUpDown6.Enabled = false;
      this.numericUpDown6.Location = new System.Drawing.Point(483, 116);
      this.numericUpDown6.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
      this.numericUpDown6.Name = "numericUpDown6";
      this.numericUpDown6.Size = new System.Drawing.Size(35, 20);
      this.numericUpDown6.TabIndex = 41;
      // 
      // numericUpDownDateCreationStartsecond
      // 
      this.numericUpDownDateCreationStartsecond.Enabled = false;
      this.numericUpDownDateCreationStartsecond.Location = new System.Drawing.Point(565, 83);
      this.numericUpDownDateCreationStartsecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numericUpDownDateCreationStartsecond.Name = "numericUpDownDateCreationStartsecond";
      this.numericUpDownDateCreationStartsecond.Size = new System.Drawing.Size(35, 20);
      this.numericUpDownDateCreationStartsecond.TabIndex = 40;
      // 
      // numericUpDownDateCreationStartMinute
      // 
      this.numericUpDownDateCreationStartMinute.Enabled = false;
      this.numericUpDownDateCreationStartMinute.Location = new System.Drawing.Point(524, 83);
      this.numericUpDownDateCreationStartMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numericUpDownDateCreationStartMinute.Name = "numericUpDownDateCreationStartMinute";
      this.numericUpDownDateCreationStartMinute.Size = new System.Drawing.Size(35, 20);
      this.numericUpDownDateCreationStartMinute.TabIndex = 39;
      // 
      // numericUpDownDateCreationStartHour
      // 
      this.numericUpDownDateCreationStartHour.Enabled = false;
      this.numericUpDownDateCreationStartHour.Location = new System.Drawing.Point(483, 83);
      this.numericUpDownDateCreationStartHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
      this.numericUpDownDateCreationStartHour.Name = "numericUpDownDateCreationStartHour";
      this.numericUpDownDateCreationStartHour.Size = new System.Drawing.Size(35, 20);
      this.numericUpDownDateCreationStartHour.TabIndex = 38;
      // 
      // numericUpDownDateModifiedStartSecond
      // 
      this.numericUpDownDateModifiedStartSecond.Enabled = false;
      this.numericUpDownDateModifiedStartSecond.Location = new System.Drawing.Point(565, 49);
      this.numericUpDownDateModifiedStartSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numericUpDownDateModifiedStartSecond.Name = "numericUpDownDateModifiedStartSecond";
      this.numericUpDownDateModifiedStartSecond.Size = new System.Drawing.Size(35, 20);
      this.numericUpDownDateModifiedStartSecond.TabIndex = 37;
      // 
      // numericUpDownDateModifiedStartMinute
      // 
      this.numericUpDownDateModifiedStartMinute.Enabled = false;
      this.numericUpDownDateModifiedStartMinute.Location = new System.Drawing.Point(524, 49);
      this.numericUpDownDateModifiedStartMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numericUpDownDateModifiedStartMinute.Name = "numericUpDownDateModifiedStartMinute";
      this.numericUpDownDateModifiedStartMinute.Size = new System.Drawing.Size(35, 20);
      this.numericUpDownDateModifiedStartMinute.TabIndex = 36;
      // 
      // numericUpDownDateModifiedStartHour
      // 
      this.numericUpDownDateModifiedStartHour.Enabled = false;
      this.numericUpDownDateModifiedStartHour.Location = new System.Drawing.Point(483, 49);
      this.numericUpDownDateModifiedStartHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
      this.numericUpDownDateModifiedStartHour.Name = "numericUpDownDateModifiedStartHour";
      this.numericUpDownDateModifiedStartHour.Size = new System.Drawing.Size(35, 20);
      this.numericUpDownDateModifiedStartHour.TabIndex = 35;
      // 
      // dateTimePickerDateLastAccessEnd
      // 
      this.dateTimePickerDateLastAccessEnd.Enabled = false;
      this.dateTimePickerDateLastAccessEnd.Location = new System.Drawing.Point(638, 117);
      this.dateTimePickerDateLastAccessEnd.Name = "dateTimePickerDateLastAccessEnd";
      this.dateTimePickerDateLastAccessEnd.Size = new System.Drawing.Size(178, 20);
      this.dateTimePickerDateLastAccessEnd.TabIndex = 34;
      this.dateTimePickerDateLastAccessEnd.Value = new System.DateTime(2017, 4, 19, 0, 0, 0, 0);
      // 
      // dateTimePickerDateCreationEnd
      // 
      this.dateTimePickerDateCreationEnd.Enabled = false;
      this.dateTimePickerDateCreationEnd.Location = new System.Drawing.Point(638, 81);
      this.dateTimePickerDateCreationEnd.Name = "dateTimePickerDateCreationEnd";
      this.dateTimePickerDateCreationEnd.Size = new System.Drawing.Size(178, 20);
      this.dateTimePickerDateCreationEnd.TabIndex = 33;
      this.dateTimePickerDateCreationEnd.Value = new System.DateTime(2017, 4, 19, 0, 0, 0, 0);
      // 
      // dateTimePickerDateModifiedEnd
      // 
      this.dateTimePickerDateModifiedEnd.Enabled = false;
      this.dateTimePickerDateModifiedEnd.Location = new System.Drawing.Point(638, 49);
      this.dateTimePickerDateModifiedEnd.Name = "dateTimePickerDateModifiedEnd";
      this.dateTimePickerDateModifiedEnd.Size = new System.Drawing.Size(178, 20);
      this.dateTimePickerDateModifiedEnd.TabIndex = 32;
      this.dateTimePickerDateModifiedEnd.Value = new System.DateTime(2017, 4, 19, 0, 0, 0, 0);
      // 
      // labelAndDateLastAccess
      // 
      this.labelAndDateLastAccess.AutoSize = true;
      this.labelAndDateLastAccess.Enabled = false;
      this.labelAndDateLastAccess.Location = new System.Drawing.Point(609, 120);
      this.labelAndDateLastAccess.Name = "labelAndDateLastAccess";
      this.labelAndDateLastAccess.Size = new System.Drawing.Size(25, 13);
      this.labelAndDateLastAccess.TabIndex = 31;
      this.labelAndDateLastAccess.Text = "and";
      // 
      // labelAndDateCreation
      // 
      this.labelAndDateCreation.AutoSize = true;
      this.labelAndDateCreation.Enabled = false;
      this.labelAndDateCreation.Location = new System.Drawing.Point(609, 86);
      this.labelAndDateCreation.Name = "labelAndDateCreation";
      this.labelAndDateCreation.Size = new System.Drawing.Size(25, 13);
      this.labelAndDateCreation.TabIndex = 30;
      this.labelAndDateCreation.Text = "and";
      // 
      // labelAndDateModified
      // 
      this.labelAndDateModified.AutoSize = true;
      this.labelAndDateModified.Enabled = false;
      this.labelAndDateModified.Location = new System.Drawing.Point(609, 52);
      this.labelAndDateModified.Name = "labelAndDateModified";
      this.labelAndDateModified.Size = new System.Drawing.Size(25, 13);
      this.labelAndDateModified.TabIndex = 29;
      this.labelAndDateModified.Text = "and";
      // 
      // dateTimePickerDateLastAccessStart
      // 
      this.dateTimePickerDateLastAccessStart.Enabled = false;
      this.dateTimePickerDateLastAccessStart.Location = new System.Drawing.Point(296, 115);
      this.dateTimePickerDateLastAccessStart.Name = "dateTimePickerDateLastAccessStart";
      this.dateTimePickerDateLastAccessStart.Size = new System.Drawing.Size(178, 20);
      this.dateTimePickerDateLastAccessStart.TabIndex = 28;
      this.dateTimePickerDateLastAccessStart.Value = new System.DateTime(2017, 4, 19, 0, 0, 0, 0);
      // 
      // dateTimePickerDateCreationStart
      // 
      this.dateTimePickerDateCreationStart.Enabled = false;
      this.dateTimePickerDateCreationStart.Location = new System.Drawing.Point(296, 79);
      this.dateTimePickerDateCreationStart.Name = "dateTimePickerDateCreationStart";
      this.dateTimePickerDateCreationStart.Size = new System.Drawing.Size(178, 20);
      this.dateTimePickerDateCreationStart.TabIndex = 27;
      this.dateTimePickerDateCreationStart.Value = new System.DateTime(2017, 4, 19, 0, 0, 0, 0);
      // 
      // dateTimePickerDateModifiedStart
      // 
      this.dateTimePickerDateModifiedStart.Enabled = false;
      this.dateTimePickerDateModifiedStart.Location = new System.Drawing.Point(296, 47);
      this.dateTimePickerDateModifiedStart.Name = "dateTimePickerDateModifiedStart";
      this.dateTimePickerDateModifiedStart.Size = new System.Drawing.Size(178, 20);
      this.dateTimePickerDateModifiedStart.TabIndex = 25;
      this.dateTimePickerDateModifiedStart.Value = new System.DateTime(2017, 4, 19, 0, 0, 0, 0);
      // 
      // comboBoxDateLastAccessBetween
      // 
      this.comboBoxDateLastAccessBetween.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.comboBoxDateLastAccessBetween.Enabled = false;
      this.comboBoxDateLastAccessBetween.FormattingEnabled = true;
      this.comboBoxDateLastAccessBetween.Items.AddRange(new object[] {
            "Between",
            "Not Between",
            "Newer than",
            "Older than"});
      this.comboBoxDateLastAccessBetween.Location = new System.Drawing.Point(156, 116);
      this.comboBoxDateLastAccessBetween.Name = "comboBoxDateLastAccessBetween";
      this.comboBoxDateLastAccessBetween.Size = new System.Drawing.Size(121, 21);
      this.comboBoxDateLastAccessBetween.TabIndex = 24;
      this.comboBoxDateLastAccessBetween.Text = "Between";
      // 
      // comboBoxDateCreationBetween
      // 
      this.comboBoxDateCreationBetween.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.comboBoxDateCreationBetween.Enabled = false;
      this.comboBoxDateCreationBetween.FormattingEnabled = true;
      this.comboBoxDateCreationBetween.Items.AddRange(new object[] {
            "Between",
            "Not Between",
            "Newer than",
            "Older than"});
      this.comboBoxDateCreationBetween.Location = new System.Drawing.Point(156, 78);
      this.comboBoxDateCreationBetween.Name = "comboBoxDateCreationBetween";
      this.comboBoxDateCreationBetween.Size = new System.Drawing.Size(121, 21);
      this.comboBoxDateCreationBetween.TabIndex = 23;
      this.comboBoxDateCreationBetween.Text = "Between";
      // 
      // comboBoxDateModifiedBetween
      // 
      this.comboBoxDateModifiedBetween.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.comboBoxDateModifiedBetween.Enabled = false;
      this.comboBoxDateModifiedBetween.FormattingEnabled = true;
      this.comboBoxDateModifiedBetween.Items.AddRange(new object[] {
            "Between",
            "Not Between",
            "Newer than",
            "Older than"});
      this.comboBoxDateModifiedBetween.Location = new System.Drawing.Point(156, 47);
      this.comboBoxDateModifiedBetween.Name = "comboBoxDateModifiedBetween";
      this.comboBoxDateModifiedBetween.Size = new System.Drawing.Size(121, 21);
      this.comboBoxDateModifiedBetween.TabIndex = 22;
      this.comboBoxDateModifiedBetween.Text = "Between";
      // 
      // checkBoxDateLastAccess
      // 
      this.checkBoxDateLastAccess.AutoSize = true;
      this.checkBoxDateLastAccess.Enabled = false;
      this.checkBoxDateLastAccess.Location = new System.Drawing.Point(22, 115);
      this.checkBoxDateLastAccess.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxDateLastAccess.Name = "checkBoxDateLastAccess";
      this.checkBoxDateLastAccess.Size = new System.Drawing.Size(110, 17);
      this.checkBoxDateLastAccess.TabIndex = 21;
      this.checkBoxDateLastAccess.Text = "Date Last Access";
      this.checkBoxDateLastAccess.UseVisualStyleBackColor = true;
      // 
      // checkBoxDateCreation
      // 
      this.checkBoxDateCreation.AutoSize = true;
      this.checkBoxDateCreation.Enabled = false;
      this.checkBoxDateCreation.Location = new System.Drawing.Point(22, 83);
      this.checkBoxDateCreation.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxDateCreation.Name = "checkBoxDateCreation";
      this.checkBoxDateCreation.Size = new System.Drawing.Size(91, 17);
      this.checkBoxDateCreation.TabIndex = 20;
      this.checkBoxDateCreation.Text = "Date Creation";
      this.checkBoxDateCreation.UseVisualStyleBackColor = true;
      // 
      // checkBoxDateModified
      // 
      this.checkBoxDateModified.AutoSize = true;
      this.checkBoxDateModified.Enabled = false;
      this.checkBoxDateModified.Location = new System.Drawing.Point(22, 52);
      this.checkBoxDateModified.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxDateModified.Name = "checkBoxDateModified";
      this.checkBoxDateModified.Size = new System.Drawing.Size(92, 17);
      this.checkBoxDateModified.TabIndex = 19;
      this.checkBoxDateModified.Text = "Date Modified";
      this.checkBoxDateModified.UseVisualStyleBackColor = true;
      // 
      // checkBoxDate
      // 
      this.checkBoxDate.AutoSize = true;
      this.checkBoxDate.Location = new System.Drawing.Point(22, 19);
      this.checkBoxDate.Margin = new System.Windows.Forms.Padding(2);
      this.checkBoxDate.Name = "checkBoxDate";
      this.checkBoxDate.Size = new System.Drawing.Size(49, 17);
      this.checkBoxDate.TabIndex = 18;
      this.checkBoxDate.Text = "Date";
      this.checkBoxDate.UseVisualStyleBackColor = true;
      this.checkBoxDate.CheckedChanged += new System.EventHandler(this.CheckBoxDate_CheckedChanged);
      // 
      // tabPageAttributes
      // 
      this.tabPageAttributes.Location = new System.Drawing.Point(4, 22);
      this.tabPageAttributes.Name = "tabPageAttributes";
      this.tabPageAttributes.Size = new System.Drawing.Size(996, 216);
      this.tabPageAttributes.TabIndex = 4;
      this.tabPageAttributes.Text = "Attributes";
      this.tabPageAttributes.UseVisualStyleBackColor = true;
      // 
      // listViewResult
      // 
      this.listViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listViewResult.HideSelection = false;
      this.listViewResult.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
      this.listViewResult.Location = new System.Drawing.Point(0, 267);
      this.listViewResult.Name = "listViewResult";
      this.listViewResult.Size = new System.Drawing.Size(1109, 350);
      this.listViewResult.TabIndex = 15;
      this.listViewResult.UseCompatibleStateImageBehavior = false;
      this.listViewResult.View = System.Windows.Forms.View.SmallIcon;
      // 
      // buttonReset
      // 
      this.buttonReset.Location = new System.Drawing.Point(1017, 229);
      this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
      this.buttonReset.Name = "buttonReset";
      this.buttonReset.Size = new System.Drawing.Size(81, 26);
      this.buttonReset.TabIndex = 14;
      this.buttonReset.Text = "Reset";
      this.buttonReset.UseVisualStyleBackColor = true;
      // 
      // buttonStop
      // 
      this.buttonStop.Enabled = false;
      this.buttonStop.Location = new System.Drawing.Point(1017, 89);
      this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
      this.buttonStop.Name = "buttonStop";
      this.buttonStop.Size = new System.Drawing.Size(81, 26);
      this.buttonStop.TabIndex = 13;
      this.buttonStop.Text = "Stop";
      this.buttonStop.UseVisualStyleBackColor = true;
      // 
      // buttonSearch
      // 
      this.buttonSearch.Location = new System.Drawing.Point(1017, 46);
      this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
      this.buttonSearch.Name = "buttonSearch";
      this.buttonSearch.Size = new System.Drawing.Size(81, 26);
      this.buttonSearch.TabIndex = 12;
      this.buttonSearch.Text = "Search";
      this.buttonSearch.UseVisualStyleBackColor = true;
      this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
      // 
      // statusStripMain
      // 
      this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStripMain.Location = new System.Drawing.Point(0, 620);
      this.statusStripMain.Name = "statusStripMain";
      this.statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
      this.statusStripMain.Size = new System.Drawing.Size(1109, 22);
      this.statusStripMain.TabIndex = 3;
      this.statusStripMain.Text = "statusStrip1";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1109, 642);
      this.Controls.Add(this.listViewResult);
      this.Controls.Add(this.statusStripMain);
      this.Controls.Add(this.buttonReset);
      this.Controls.Add(this.tabControlMain);
      this.Controls.Add(this.buttonStop);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.buttonSearch);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "FormMain";
      this.Text = "Fred Ultra File Search";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainFormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.ClientSizeChanged += new System.EventHandler(this.FormMain_ClientSizeChanged);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tabControlMain.ResumeLayout(false);
      this.tabPageFilesAndFolders.ResumeLayout(false);
      this.panelMain.ResumeLayout(false);
      this.panelMain.PerformLayout();
      this.tabPageContaining.ResumeLayout(false);
      this.tabPageContaining.PerformLayout();
      this.tabPageDateAndSize.ResumeLayout(false);
      this.tabPageDateAndSize.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeTo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeFrom)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateModifiedEndSecond)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateModifiedEndMinute)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateModifiedEndHour)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateCreationStartsecond)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateCreationStartMinute)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateCreationStartHour)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateModifiedStartSecond)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateModifiedStartMinute)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateModifiedStartHour)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem personalizeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem languagetoolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem DisplayToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem SmallToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MediumToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem LargeToolStripMenuItem;
    private System.Windows.Forms.TabControl tabControlMain;
    private System.Windows.Forms.TabPage tabPageFilesAndFolders;
    private System.Windows.Forms.TabPage tabPageContaining;
    private System.Windows.Forms.TabPage tabPageDateAndSize;
    private System.Windows.Forms.StatusStrip statusStripMain;
    private System.Windows.Forms.Button buttonReset;
    private System.Windows.Forms.Button buttonStop;
    private System.Windows.Forms.Button buttonSearch;
    private System.Windows.Forms.Panel panelMain;
    private System.Windows.Forms.ComboBox comboBoxMode;
    private System.Windows.Forms.CheckBox checkBoxShowFoldernames;
    private System.Windows.Forms.CheckBox checkBoxShowFilenames;
    private System.Windows.Forms.CheckBox checkBoxAppendResults;
    private System.Windows.Forms.CheckBox checkBoxIncludeHiddenFolders;
    private System.Windows.Forms.Button buttonBrowsePath;
    private System.Windows.Forms.Label labelStartingFolders;
    private System.Windows.Forms.CheckBox checkBoxScanInsubFolders;
    private System.Windows.Forms.Label labelFileNames;
    private System.Windows.Forms.ListView listViewResult;
    private System.Windows.Forms.Label labelSelect;
    private System.Windows.Forms.Label labelMode;
    private System.Windows.Forms.ComboBox comboBoxStartingFolder;
    private System.Windows.Forms.ComboBox comboBoxFileName;
    private System.Windows.Forms.CheckBox checkBoxCaseSensitive;
    private System.Windows.Forms.CheckBox checkBoxwholeWords;
    private System.Windows.Forms.CheckBox checkBoxWithout;
    private System.Windows.Forms.RadioButton radioButtonContainingTextMatchAll;
    private System.Windows.Forms.RadioButton radioButtonContainingTextMatchAny;
    private System.Windows.Forms.ComboBox comboBoxSearchText;
    private System.Windows.Forms.Label labelContainingTextMode;
    private System.Windows.Forms.ComboBox comboBoxContainingTextMode;
    private System.Windows.Forms.CheckBox checkBoxSkipAudioFiles;
    private System.Windows.Forms.CheckBox checkBoxSkipImageFiles;
    private System.Windows.Forms.CheckBox checkBoxSkipVideoFiles;
    private System.Windows.Forms.CheckBox checkBoxSkipSystemFiles;
    private System.Windows.Forms.CheckBox checkBoxSkipHiddenFiles;
    private System.Windows.Forms.Label labelSearchText;
    private System.Windows.Forms.DateTimePicker dateTimePickerDateModifiedStart;
    private System.Windows.Forms.ComboBox comboBoxDateLastAccessBetween;
    private System.Windows.Forms.ComboBox comboBoxDateCreationBetween;
    private System.Windows.Forms.ComboBox comboBoxDateModifiedBetween;
    private System.Windows.Forms.CheckBox checkBoxDateLastAccess;
    private System.Windows.Forms.CheckBox checkBoxDateCreation;
    private System.Windows.Forms.CheckBox checkBoxDateModified;
    private System.Windows.Forms.CheckBox checkBoxDate;
    private System.Windows.Forms.DateTimePicker dateTimePickerDateLastAccessStart;
    private System.Windows.Forms.DateTimePicker dateTimePickerDateCreationStart;
    private System.Windows.Forms.DateTimePicker dateTimePickerDateLastAccessEnd;
    private System.Windows.Forms.DateTimePicker dateTimePickerDateCreationEnd;
    private System.Windows.Forms.DateTimePicker dateTimePickerDateModifiedEnd;
    private System.Windows.Forms.Label labelAndDateLastAccess;
    private System.Windows.Forms.Label labelAndDateCreation;
    private System.Windows.Forms.Label labelAndDateModified;
    private System.Windows.Forms.NumericUpDown numericUpDownDateModifiedStartSecond;
    private System.Windows.Forms.NumericUpDown numericUpDownDateModifiedStartMinute;
    private System.Windows.Forms.NumericUpDown numericUpDownDateModifiedStartHour;
    private System.Windows.Forms.NumericUpDown numericUpDown13;
    private System.Windows.Forms.NumericUpDown numericUpDown14;
    private System.Windows.Forms.NumericUpDown numericUpDown15;
    private System.Windows.Forms.NumericUpDown numericUpDown10;
    private System.Windows.Forms.NumericUpDown numericUpDown11;
    private System.Windows.Forms.NumericUpDown numericUpDown12;
    private System.Windows.Forms.NumericUpDown numericUpDownDateModifiedEndSecond;
    private System.Windows.Forms.NumericUpDown numericUpDownDateModifiedEndMinute;
    private System.Windows.Forms.NumericUpDown numericUpDownDateModifiedEndHour;
    private System.Windows.Forms.NumericUpDown numericUpDown4;
    private System.Windows.Forms.NumericUpDown numericUpDown5;
    private System.Windows.Forms.NumericUpDown numericUpDown6;
    private System.Windows.Forms.NumericUpDown numericUpDownDateCreationStartsecond;
    private System.Windows.Forms.NumericUpDown numericUpDownDateCreationStartMinute;
    private System.Windows.Forms.NumericUpDown numericUpDownDateCreationStartHour;
    private System.Windows.Forms.CheckBox checkBoxSize;
        private System.Windows.Forms.TabPage tabPageAttributes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownSizeTo;
        private System.Windows.Forms.Label labelSizeAnd;
        private System.Windows.Forms.ComboBox comboBoxSizeMbKb;
        private System.Windows.Forms.NumericUpDown numericUpDownSizeFrom;
        private System.Windows.Forms.ComboBox comboBoxBetweenSize;
    }
}