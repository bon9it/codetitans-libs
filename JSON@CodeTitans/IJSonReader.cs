﻿#region License
/*
    Copyright (c) 2010, Paweł Hofman (CodeTitans)
    All Rights Reserved.

    Licensed under the Apache License version 2.0.
    For more information please visit:

    http://codetitans.codeplex.com/license
        or
    http://www.apache.org/licenses/


    For latest source code, documentation, samples
    and more information please visit:

    http://codetitans.codeplex.com/
*/
#endregion

using System;
using System.IO;

namespace CodeTitans.JSon
{
    /// <summary>
    /// Interface defining all read operation that might convert a JSON string into its tree representation that could be traversed.
    /// </summary>
    public interface IJSonReader
    {
        /// <summary>
        /// Converts a JSON string from given input into a tree of .NET arrays, dictionaries, strings and decimals.
        /// </summary>
        object Read(TextReader input);

        /// <summary>
        /// Converts a JSON string from given input into a tree of .NET arrays, dictionaries, strings and decimals.
        /// </summary>
        object Read(String input);

        /// <summary>
        /// Converts a JSON string from given input into a tree of .NET arrays, dictionaries, strings and decimals.
        /// </summary>
        object Read(TextReader input, JSonReaderNumberFormat format);

        /// <summary>
        /// Converts a JSON string from given input into a tree of .NET arrays, dictionaries, strings and decimals.
        /// </summary>
        object Read(String input, JSonReaderNumberFormat format);

        /// <summary>
        /// Converts a JSON string from given input into a tree of JSON-specific objects.
        /// It then allows easier deserialization for objects implementing <see cref="IJSonObject"/> interface as those objects expose
        /// more functionality then the standard .NET ones.
        /// </summary>
        IJSonObject ReadAsJSonObject(TextReader input);

        /// <summary>
        /// Converts a JSON string from given input into a tree of JSON-specific objects.
        /// It then allows easier deserialization for objects implementing <see cref="IJSonObject"/> interface as those objects expose
        /// more functionality then the standard .NET ones.
        /// </summary>
        IJSonObject ReadAsJSonObject(String input);

        /// <summary>
        /// Converts a JSON string from given input into a tree of JSON-specific objects.
        /// It then allows easier deserialization for objects implementing <see cref="IJSonObject"/> interface as those objects expose
        /// more functionality then the standard .NET ones.
        /// </summary>
        IJSonObject ReadAsJSonObject(TextReader input, JSonReaderNumberFormat format);

        /// <summary>
        /// Converts a JSON string from given input into a tree of JSON-specific objects.
        /// It then allows easier deserialization for objects implementing <see cref="IJSonObject"/> interface as those objects expose
        /// more functionality then the standard .NET ones.
        /// </summary>
        IJSonObject ReadAsJSonObject(String input, JSonReaderNumberFormat format);

        /// <summary>
        /// Converts a JSON string from given input into a tree of JSON-specific objects.
        /// It then allows easier deserialization for objects implementing <see cref="IJSonMutableObject"/> interface as those objects expose
        /// more functionality then the standard .NET ones.
        /// </summary>
        IJSonMutableObject ReadAsJSonMutableObject(TextReader input);

        /// <summary>
        /// Converts a JSON string from given input into a tree of JSON-specific objects.
        /// It then allows easier deserialization for objects implementing <see cref="IJSonMutableObject"/> interface as those objects expose
        /// more functionality then the standard .NET ones.
        /// </summary>
        IJSonMutableObject ReadAsJSonMutableObject(String input);

        /// <summary>
        /// Converts a JSON string from given input into a tree of JSON-specific objects.
        /// It then allows easier deserialization for objects implementing <see cref="IJSonMutableObject"/> interface as those objects expose
        /// more functionality then the standard .NET ones.
        /// </summary>
        IJSonMutableObject ReadAsJSonMutableObject(TextReader input, JSonReaderNumberFormat format);

        /// <summary>
        /// Converts a JSON string from given input into a tree of JSON-specific objects.
        /// It then allows easier deserialization for objects implementing <see cref="IJSonMutableObject"/> interface as those objects expose
        /// more functionality then the standard .NET ones.
        /// </summary>
        IJSonMutableObject ReadAsJSonMutableObject(String input, JSonReaderNumberFormat format);
    }
}
