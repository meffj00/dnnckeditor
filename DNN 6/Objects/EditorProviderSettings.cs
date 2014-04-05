﻿/*
 * CKEditor Html Editor Provider for DotNetNuke
 * ========
 * http://dnnckeditor.codeplex.com/
 * Copyright (C) Ingo Herbote
 *
 * The software, this file and its contents are subject to the CKEditor Provider
 * License. Please read the license.txt file before using, installing, copying,
 * modifying or distribute this file or part of its contents. The contents of
 * this file is part of the Source Code of the CKEditor Provider.
 */

namespace WatchersNET.CKEditor.Objects
{
    #region

    using System.Collections.Generic;

    using WatchersNET.CKEditor.Constants;

    #endregion

    /// <summary>
    /// The Editor Provider Settings
    /// </summary>
    public class EditorProviderSettings : object
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditorProviderSettings"/> class. 
        /// </summary>
        public EditorProviderSettings()
        {
            this.UseAnchorSelector = true;
            this.FileListPageSize = 20;
            this.FileListViewMode = FileListView.DetailView;
            this.SettingMode = SettingsMode.Portal;
            this.DefaultLinkMode = LinkMode.RelativeURL;
            this.InjectSyntaxJs = true;
            this.BrowserRootDirId = -1;
            this.UploadDirId = -1;
            this.ResizeHeight = -1;
            this.ResizeWidth = -1;
            this.BrowserRoles = "0;Administrators;";
            this.Browser = "standard";
            this.ToolBarRoles = new List<ToolbarRoles> { new ToolbarRoles { RoleId = 0, Toolbar = "Full" } };

            this.Config = new EditorConfig();
        }
        #region Properties

        /// <summary>
        /// Gets or sets How many Items to Show per Page on the File List.
        /// </summary>
        /// <value>
        /// How many Items to Show per Page on the File List.
        /// </value>
        public int FileListPageSize { get; set; }

        /// <summary>
        /// Gets or sets the file list view mode.
        /// </summary>
        /// <value>
        /// The file list view mode.
        /// </value>
        public FileListView FileListViewMode { get; set; }

        /// <summary>
        /// Gets or sets the default link mode.
        /// </summary>
        /// <value>
        /// The default link mode.
        /// </value>
        public LinkMode DefaultLinkMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [use anchor selector].
        /// </summary>
        /// <value>
        ///  <c>true</c> if [use anchor selector]; otherwise, <c>false</c>.
        /// </value>
        public bool UseAnchorSelector { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show page links tab first].
        /// </summary>
        /// <value>
        ///  <c>true</c> if [show page links tab first]; otherwise, <c>false</c>.
        /// </value>
        public bool ShowPageLinksTabFirst { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Use Sub directory for Users.
        /// </summary>
        public bool SubDirs { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Inject the Syntax 
        /// jQuery Java Script
        /// </summary>
        public bool InjectSyntaxJs { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether The Browser Root Directory Id
        /// </summary>
        public int BrowserRootDirId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether The Upload Directory Id
        /// </summary>
        public int UploadDirId { get; set; }

        /// <summary>
        /// Gets or sets the custom JS file.
        /// </summary>
        /// <value>
        /// The custom JS file.
        /// </value>
        public string CustomJsFile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Default Resize Image Height
        /// </summary>
        public int ResizeHeight { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Default Resize Image Width
        /// </summary>
        public int ResizeWidth { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Toolbar Roles
        /// </summary>
        public List<ToolbarRoles> ToolBarRoles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Blank Initial text
        /// </summary>
        public string BlankText { get; set; }

        /// <summary>
        /// Gets or sets the browser.
        /// </summary>
        /// <value>
        /// The browser.
        /// </value>
        public Browser BrowserMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Editor File Browser
        /// </summary>
        public string Browser { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Allowed Browser Roles
        /// </summary>
        public string BrowserRoles { get; set; }

        /// <summary>
        /// Gets or sets the width of the editor as string.
        /// </summary>
        /// <value>
        /// The width of the browser.
        /// </value>
        public string EditorWidth { get; set; }

        /// <summary>
        /// Gets or sets the height of the editor as string.
        /// </summary>
        /// <value>
        /// The height of the browser.
        /// </value>
        public string EditorHeight { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Current Setting Mode
        /// </summary>
        public SettingsMode SettingMode { get; set; }

        /// <summary>
        /// Gets or sets the Editor configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public EditorConfig Config { get; set; }

        #endregion
    }
}