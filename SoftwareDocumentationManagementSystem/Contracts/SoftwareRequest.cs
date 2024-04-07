using System.ComponentModel.DataAnnotations;
using SoftwareDocumentationManagementSystem.Core.Models;

namespace SoftwareDocumentationManagementSystem.API.Contracts;

public record SoftwareRequest(
    [Required][MaxLength(Software.MAX_TITLE_LENGTH)] string Title,
    [Required] string Description,
    [Required] Guid AuthorId,
    [Required] Guid CompanyId,
    [Required] bool IsPublic,
    [Required] string GitUrl);
