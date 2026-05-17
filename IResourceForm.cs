/*
 * LfdResourceEditor, All-in-one editor for the Lucasarts .LFD resource file format
 * Copyright (C) 2026 Michael Gaisser (mjgaisser@gmail.com)
 * Licensed under the MPL v2.0 or later.
 * 
 * Full notice in Program.cs
 * Version: 0.1
 */

/* CHANGELOG
 * v0.1, 260517
 * - created
 */

using Idmr.LfdReader;

namespace LfdResourceEditor
{
	/// <summary>Defines members common to the MDI forms.</summary>
	internal interface IResourceForm
	{
		/// <summary>Gets the Lfd for the form.</summary>
		LfdFile ParentLfd { get; }

		/// <summary>Gets the Lfd Resource for the form.</summary>
		Resource Resource { get; }

		/// <summary>Close the Form, bypassing unsaved data checks.</summary>
		void ForceClose();
	}
}
