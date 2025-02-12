﻿using System;

namespace CloudFlare.Client.Models;

/// <summary>
/// Relative Uri
/// </summary>
public class RelativeUri : Uri
{
    /// <summary>
    /// Consructor for relative uri
    /// </summary>
    /// <param name="uriString">The uri string</param>
    public RelativeUri(string uriString) : base(uriString, UriKind.Relative)
    {
    }

    internal RelativeUri AddParameters(ParameterBuilder parameterBuilder)
    {
        return !parameterBuilder.Any() ? this : new RelativeUri($"{this.OriginalString}?{parameterBuilder}");
    }
}
