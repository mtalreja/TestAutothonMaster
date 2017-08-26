﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace DesktopWeb
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the DesktopWebRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
    [RepositoryFolder("0f465d88-dabd-4694-8fe0-65f35f1aa8b6")]
    public partial class DesktopWebRepository : RepoGenBaseFolder
    {
        static DesktopWebRepository instance = new DesktopWebRepository();

        /// <summary>
        /// Gets the singleton class instance representing the DesktopWebRepository element repository.
        /// </summary>
        [RepositoryFolder("0f465d88-dabd-4694-8fe0-65f35f1aa8b6")]
        public static DesktopWebRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public DesktopWebRepository() 
            : base("DesktopWebRepository", "/", null, 0, false, "0f465d88-dabd-4694-8fe0-65f35f1aa8b6", ".\\RepositoryImages\\DesktopWebRepository0f465d88.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("0f465d88-dabd-4694-8fe0-65f35f1aa8b6")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
    public partial class DesktopWebRepositoryFolders
    {
    }
#pragma warning restore 0436
}