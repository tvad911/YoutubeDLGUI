﻿//
// FolderChooserDialog.cs
//
// Author:
//       Brian Allred <brian.d.allred@gmail.com>
//
// Copyright (c) 2015 Brian Allred
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using Gtk;

namespace YoutubeDLGui
{
    /// <summary>
    ///     Folder chooser dialog.
    /// </summary>
    public partial class FolderChooserDialog : Dialog
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="YoutubeDLGui.FolderChooserDialog" /> class.
        /// </summary>
        public FolderChooserDialog()
        {
            Build();
        }

        /// <summary>
        ///     Gets the folder.
        /// </summary>
        /// <value>The folder.</value>
        public string Folder => folderChooserWidget.Filename;

        /// <summary>
        ///     Raises the button ok clicked event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        protected void OnButtonOkClicked(object sender, EventArgs e)
        {
            Respond(ResponseType.Ok);
        }

        /// <summary>
        ///     Raises the button cancel clicked event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        protected void OnButtonCancelClicked(object sender, EventArgs e)
        {
            Respond(ResponseType.Cancel);
        }
    }
}