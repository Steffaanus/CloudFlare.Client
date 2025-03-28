﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CloudFlare.Client.Api.Certificates;
using CloudFlare.Client.Api.Display;
using CloudFlare.Client.Api.Result;

namespace CloudFlare.Client.Client.Certificates;

/// <summary>
/// Interface for interacting with certificates
/// </summary>
public interface ICertificates
{
    /// <summary>
    /// Get all certificates
    /// </summary>
    /// <param name="zoneId">The zone id</param>
    /// <param name="displayOptions">Display options</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A list of all certificates</returns>
    Task<CloudFlareResult<IReadOnlyList<OriginCaCertificate>>> GetAsync(string zoneId, DisplayOptions displayOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a certificate
    /// </summary>
    /// <param name="certificateId">The certificate id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The certificate</returns>
    Task<CloudFlareResult<OriginCaCertificate>> GetDetailsAsync(string certificateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an Origin CA certificate.
    /// </summary>
    /// <param name="newCertificate">The new certificate</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created certificate</returns>
    Task<CloudFlareResult<OriginCaCertificate>> AddAsync(NewOriginCaCertificate newCertificate, CancellationToken cancellationToken = default);

    /// <summary>
    /// Revoke a certificate
    /// </summary>
    /// <param name="certificateId">The certificate id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The revoked certificate</returns>
    Task<CloudFlareResult<OriginCaCertificate>> RevokeAsync(string certificateId, CancellationToken cancellationToken = default);
}
